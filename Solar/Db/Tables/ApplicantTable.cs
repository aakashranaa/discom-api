﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Solar.Db.Tables
{
    public class Applicant
    {
        [Column("EmailId")]
        public string EmailId { get; set; }
        public string? ReceiptConsumerName { get; set; }

        public string? Pin { get; set; }
        public int ApplicantID { get; set; }

        [Column("ConsumerNo")]
        public string? ConsumerNo { get; set; }
        public string? Address { get; set; }
        public string? Mobile { get; set; }
        public string? IndividualLastName { get; set; }
        public string? IndividualFirstName { get; set; }
    }
}
