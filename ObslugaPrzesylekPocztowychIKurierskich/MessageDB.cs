using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaPrzesylekPocztowychIKurierskich
{
    public class MessageDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MessageDB>
    {
        protected override void Seed(MessageDB context)
        {
            DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15, 18);
            DateTime date2 = new DateTime(2008, 8, 29, 19, 27, 15, 18);
            context.messages.Add(new Message(null, null, 0, 0, 0, date1, date2, false, false, 0));
            context.SaveChanges();
            base.Seed(context);
        }
    }

    public class MessageDB : DbContext
    {
        public MessageDB() 
            :base ("DatabasePOST")
        {
            System.Data.Entity.Database.SetInitializer(new MessageDBInitializer());
        }

        public virtual DbSet<Message> messages { get; set; }
    }
}
