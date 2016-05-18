using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum MsgSize
{
    postcard,
    letter,
    smallPackage,
    averagePackage,
    bigPackage,
    giganticPackage
}
public enum MsgStatus
{
    received,
    onTheWay,
    readyToSend
}

namespace ObslugaPrzesylekPocztowychIKurierskich
{
    public class Message
    {
        private int Id { get; set; }
        private Person Sender { get; set; }
        private Person Receiver { get; set; }
        private double Cost { get; set; }
        private MsgSize Size;
        private MsgStatus Status;
        private DateTime SendTime;
        private DateTime ReceiveTime;
        private bool Priority { get; set; }
        private bool PayAfter { get; set; }
        private int MessangerId { get; set; }

        public Message(Person _sender, Person _receiver, double _cost, MsgSize _size, MsgStatus _status, DateTime _send, DateTime _receive, bool _priority, bool _payAfter, int _msng)
        {
            Sender = _sender;
            Receiver = _receiver;
            Cost = _cost;
            Size = _size;
            Status = _status;
            SendTime = _send;
            ReceiveTime = _receive;
            Priority = _priority;
            PayAfter = _payAfter;
            MessangerId = _msng;
        }

        public bool addMessageToDB(Message msg)
        {
            using (var ctx = new MessageDB())
            {
                ctx.messages.Add(msg);
                try
                {
                    ctx.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                    return false;
                }
            }
            return true;
        }

        public bool deleteAllMessagesFromDB()
        {
            using (var ctx = new MessageDB())
            {
                foreach (var item in ctx.messages)
                    ctx.messages.Remove(item);
                try
                {
                    ctx.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                    return false;
                }
            }
            return true;
        }
    }
}
