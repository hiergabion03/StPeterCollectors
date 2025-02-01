namespace StPeterCollectors.Models
{
    public class sp_total_all
    {
        public int Id { get; set; }
        public int account_total { get; set; }
        public decimal qcomm_total { get; set; }
        public decimal qncomm_total { get; set; }
        public int collected_total { get; set; }
        public decimal collection_total { get; set; }
        public decimal adv_collection_total { get; set; }
        public decimal comm_handl_fee { get; set; }
        public decimal ncomm_handl_fee { get; set; }
        public decimal quota_com_total { get; set; }
        public decimal quota_ncom_total { get; set; }
        public decimal total_quota { get; set; }
        public decimal total_tap { get; set; }
        public decimal total_balance { get; set; }
    }
}
