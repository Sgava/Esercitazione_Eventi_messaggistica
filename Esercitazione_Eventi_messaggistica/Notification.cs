namespace Esercitazione_Eventi_messaggistica
{
    public class Notification
    {
        public string Message { get; set; }

        public string Sender { get; set; }

        public DateTime Now { get; set; }



        public Notification(string v, string sender, DateTime now)
        {
            Message = v;
            Sender = sender;    
            Now = now;
        }
    }
}