using System;
using System;
using System;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Backend.Objects
{
    class Order
    {
        Database db = new Database();
        DateTime orderDate;

        //used at receipt page
        public Order(String orderNum, String orderUserName, List<Item> orderItems , Tax orderTax, Payment orderPayment,String dineOrTakeAway)
        {
            //set based on current time
            OrderDate = DateTime.Now;

            OrderNum = orderNum;
            OrderUserName = orderUserName;
            OrderItems = orderItems;
            OrderTax = orderTax;
            OrderPayment = orderPayment;
            DineOrTakeAway = dineOrTakeAway;

            IsDone = false;
        }

        //used to get orders from DB
        public Order(int orderID, String orderNum,DateTime orderDate,int dineOrTakeAway,int userID,int isCompleted)
        {
            OrderID = orderID;
            OrderNum = orderNum;
            OrderDate = orderDate;
            UserID = userID;

            if (dineOrTakeAway == 0)
            {
                DineOrTakeAway = "Dine-in";
            }
            else if (dineOrTakeAway == 1)
            {
                DineOrTakeAway = "Take away";
            }

            if (isCompleted == 1)
            {
                IsDone = true;
            }
            else
                IsDone = false;

        }

        //can get the values from the properties
        public String OrderNum { get; set; }
        public String OrderUserName { get; set; }//contain properties Name and Position(get and set)
        public List<Item> OrderItems { get; set; }
        public DateTime OrderDate { get; }
        public Tax OrderTax { get; set;} // contains properties SerTax and SerCharge(get and set), use this to get service tax/charge
        public Payment OrderPayment { get; set; } // contain properties PaidAmt and TotalAmt(get and set), use this to get paid/total amount
        public String DineOrTakeAway { get; set; }
        public bool IsDone { get; set; }//set if the order have been done at kitchen

        //properties for database id
        public int OrderID { get; set; }
        public int UserID { get; set; }



        public void AddToOrderTable()
        {
            int takeaway = 0;
            int user_id = 0;
            int order_id = 0;
            int item_id = 0;

            if (DineOrTakeAway.Equals("Dine-in"))
            {
                takeaway = 0;
            }
            else if(DineOrTakeAway.Equals("Take away"))
            {
                takeaway = 1;
            }

            db.OpenDBConnection();

            //get user id
            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "Select id from user where user_name = '" + OrderUserName + "'";
            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();
            while (db.Sqlite_datareader.Read())
            {
                user_id = db.Sqlite_datareader.GetInt32(0);
            }

            //clear previous statements
            db.Sqlite_cmd.Dispose();

            //insert into db
            db.Sqlite_cmd.CommandText = "Insert into purchase_order(order_num,takeaway,created_time,user_id,is_completed) values('"+OrderNum+"'," +takeaway+ ",'" + OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "',"+ user_id+",0)";
            db.Sqlite_cmd.ExecuteNonQuery();

            //clear previous statements
            db.Sqlite_cmd.Dispose();

            //get order id
            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "Select id from purchase_order where order_num = '" + OrderNum + "'";
            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();
            while (db.Sqlite_datareader.Read())
            {
                order_id = db.Sqlite_datareader.GetInt32(0);
            }


            foreach (Item item in OrderItems)
            {
                //clear previous statements
                db.Sqlite_cmd.Dispose();

                //get order id
                db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                db.Sqlite_cmd.CommandText = "Select id from item where name = '" + item.Name + "'";
                db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();
                while (db.Sqlite_datareader.Read())
                {
                    item_id = db.Sqlite_datareader.GetInt32(0);
                }

                //clear previous statements
                db.Sqlite_cmd.Dispose();
                db.Sqlite_cmd.CommandText = "INSERT INTO order_product(order_id,item_id,quantity) VALUES(@order_id,@item_id,@qty)";
                db.Sqlite_cmd.Parameters.AddWithValue("@order_id", order_id);
                db.Sqlite_cmd.Parameters.AddWithValue("@item_id", item_id);
                db.Sqlite_cmd.Parameters.AddWithValue("@qty", item.Quantity);
                db.Sqlite_cmd.ExecuteNonQuery();

            }

            db.CloseDBConnection();

        }


    }
    
}
