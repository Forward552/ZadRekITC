using ZadanieRekrutacyjneITC.Entities;

namespace ZadanieRekrutacyjneITC
{
    public static class Logging
    {
        public static void Log(string value)
        {
            using (DataBaseContext dbContext = new DataBaseContext())
            {
                Log l = new Log();
                l.Operation = value;
                l.DocumentId = 0;
                dbContext.Logs.Add(l);
                dbContext.SaveChanges();
            }
        }
        public static void Log(string value,int id)
        {
            using (DataBaseContext dbContext = new DataBaseContext())
            {
                Log l = new Log();
                l.Operation = value;
                l.DocumentId = id;
                dbContext.Logs.Add(l);
                dbContext.SaveChanges();
            }
        }


    }
}
