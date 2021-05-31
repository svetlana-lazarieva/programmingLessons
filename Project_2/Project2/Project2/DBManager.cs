using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Project2
{
    public class DBManager
    {
        private MyModel context;
        private Dictionary<string,object> tablesToNames = new Dictionary<string, object>();

        public DBManager(MyModel dbContext)
        {
            context = dbContext;
            tablesToNames.Add("User", context.Users);
            tablesToNames.Add("Product", context.Products);
            tablesToNames.Add("Order", context.Orders);
        }

        public void AddOrUpdate<T>(T tableItem, bool update = false) where T : TableBase
        {
            string tableType = tableItem.GetType().Name;
            var table = tablesToNames[tableType] as DbSet<T>;
            if(!update)
            {
                table.Add(tableItem);
            }

            context.SaveChanges();
        }

        public void Delete<T>(T tableItem) where T : TableBase
        {
            string tableType = tableItem.GetType().Name;
            var table = tablesToNames[tableType] as DbSet<T>;
            var tableData = table.FirstOrDefault(x => x.Id == tableItem.Id);

            if(tableData != null)
            {
                table.Remove(tableData);
            }
        }

    }
}