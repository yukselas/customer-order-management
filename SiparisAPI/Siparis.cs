

namespace SiparisAPI
{
    public class Siparis {

		public int Id { get; set; }
        public string customerOrderNo { get; set; } = string.Empty;
        public string departureAddress  { get; set; } = string.Empty;
	    public string destinationAddress  { get; set; } = string.Empty;
	    public string quantity { get; set; } = string.Empty;
	    public string quantityUnit { get; set; } = string.Empty;
	    public string weight { get; set; } = string.Empty;
	    public string weightUnit { get; set; } = string.Empty;
	    public string materialCode { get; set; } = string.Empty;
	    public string material { get; set; } = string.Empty;
	    public string note { get; set; } = string.Empty;
	    public string status { get; set; } = string.Empty;
    }
}
