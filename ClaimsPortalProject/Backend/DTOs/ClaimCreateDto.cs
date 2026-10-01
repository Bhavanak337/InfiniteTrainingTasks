namespace ClaimProcessingAPI.DTOs
{
    public class ClaimCreateDto
    {
        public string ClaimNumber { get; set; }
        public int MemberId { get; set; }
        public int ProviderId { get; set; }
        public string ClaimType { get; set; }
        public DateTime ServiceDate { get; set; }
        public decimal BilledAmount { get; set; }

        public List<CreateClaimLineDto> ClaimLines { get; set; }
    }
}