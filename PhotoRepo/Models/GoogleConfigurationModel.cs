﻿namespace PhotoRepo.Models
{
    public class GoogleConfigurationModel
    {
		public string Type { get; set; }
		public string ProjectId { get; set; }
		public string PrivateKeyId { get; set; }
		public string PrivateKey { get; set; }
		public string ClientEmail { get; set; }
		public string ClientId { get; set; }
		public string AuthUri { get; set; }
		public string TokenUri { get; set; }
		public string AuthProviderx509CertUrl { get; set; }
		public string Clientx509CertUrl { get; set; }
    }
}