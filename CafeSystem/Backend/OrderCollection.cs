using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSystem.Backend.Objects;

namespace CafeSystem.Backend
{
    class OrderCollection
    {
       // private static List<Order> orderList = new List<Order>();

        //for getting all rows in purchase_order table first
        private List<Order> orderList = new List<Order>();
        private Database db = new Database();


        public OrderCollection()
        {
            GetFromOrderTable();
        }



        public List<Order> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }

        public void GetFromOrderTable()
        {

            db.OpenDBConnection();
            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "SELECT id,order_num,datetime(created_time),takeaway,user_id,is_completed FROM purchase_order";

            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database

            while (db.Sqlite_datareader.Read())//add order id, orderNum,datetime, dineOrTakeAway,user_id,isDone
            {
                Order newOrder;
                DateTime orderDate = Convert.ToDateTime(db.Sqlite_datareader[2].ToString());

                newOrder = new Order(db.Sqlite_datareader.GetInt32(0), db.Sqlite_datareader.GetString(1), orderDate, db.Sqlite_datareader.GetInt32(3),
                    db.Sqlite_datareader.GetInt32(4),db.Sqlite_datareader.GetInt32(5));

                OrderList.Add(newOrder);
            }


            //loops through order one by one to add the item
            foreach (Order order in OrderList)
            {
                decimal serTax = 0;
                decimal serCharge = 0;
                decimal subTotal = 0;
                decimal totalAmt = 0;

                db.Sqlite_cmd.Dispose();

                //get user name of order
                db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                db.Sqlite_cmd.CommandText = "SELECT user_name from user inner join purchase_order on user.id =" + order.UserID;

                db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database

                while (db.Sqlite_datareader.Read())//add order id, orderNum,datetime, dineOrTakeAway,isDone
                {
                    order.OrderUserName = db.Sqlite_datareader.GetString(0);
                }

                List<Item> orderItemList = new List<Item>();

                db.Sqlite_cmd.Dispose();

                //get items
                db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                db.Sqlite_cmd.CommandText = "Select item_id,quantity from order_product where order_id = " + order.OrderID;
                db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();
                while (db.Sqlite_datareader.Read())
                {
                    orderItemList.Add(new Item(db.Sqlite_datareader.GetInt32(0), db.Sqlite_datareader.GetInt32(1)));
                }

                //adding more detail (string name, decimal price, decimal cost, String description, String image, String category, String type)
                foreach (Item item in orderItemList)
                {
                    //discard preveious commands
                    db.Sqlite_cmd.Dispose();

                    db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                    db.Sqlite_cmd.CommandText = "select name,price,description,image,category,type " +
                        "from item inner join order_product " +
                        "on item.id = "+item.ItemID;
                    db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();
                    while (db.Sqlite_datareader.Read())
                    {
                        item.Name = db.Sqlite_datareader.GetString(0);
                        item.Price = db.Sqlite_datareader.GetDecimal(1);
                        item.Description = db.Sqlite_datareader.GetString(2);
                        item.Image = db.Sqlite_datareader.GetString(3);
                        item.Category = db.Sqlite_datareader.GetString(4);
                        item.Type = db.Sqlite_datareader.GetString(5);
                    }

                    subTotal += item.Price*item.Quantity;

                }//end item foreach

                //set items
                order.OrderItems = orderItemList;

                //set the tax
                serTax = subTotal * 6 / 100;

                if (order.DineOrTakeAway.Equals("Dine-in"))
                {
                    serCharge = subTotal * 10 / 100;
                }

                //set up the tax
                order.OrderTax = new Tax(serTax, serCharge);

                //set up paid amount
                totalAmt = subTotal + order.OrderTax.SerTax + order.OrderTax.SerCharge;
                order.OrderPayment = new Payment();
                order.OrderPayment.TotalAmt = totalAmt;

            }//end order foreach

            db.CloseDBConnection();


        }



    }
}
