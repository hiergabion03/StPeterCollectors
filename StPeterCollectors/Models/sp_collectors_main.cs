namespace StPeterCollectors.Models
{
    public class sp_collectors_main
    {
        public int? id { get; set; }
        public string collector_name { get; set; }
        public string contract_no { get; set; }
        public string plan_holder { get; set; }
        public string description { get; set; }
        public DateTime effectivity_date { get; set; }
        public DateTime due_date { get; set; }
        public decimal? quota_comm { get; set; }
        public decimal? quota_ncomm { get; set; }
        public decimal cbi { get; set; }
        public int inst_no { get; set; }
        public int aging { get; set; }
        public decimal balance { get; set; }
        public string  tax { get; set; }

        public string ins { get; set; }
        public int? or_no { get; set; }
        public DateTime? or_date { get; set; }
        public decimal? coll_due { get; set; }
        public decimal? coll_advance { get; set; }


    }
}
