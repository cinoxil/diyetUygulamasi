namespace diyetUygulamasi.database
{
    public class hastalik
    {
        public string adi { get; set; }


        public hastalik(string _ad)
        {
            adi = _ad;
        }

        public override string ToString()
        {
            return adi;
        }
    }
}