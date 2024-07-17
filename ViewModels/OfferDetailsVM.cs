﻿using Projekt_Zespolowy.Models;

namespace Projekt_Zespolowy.ViewModels
{
	public class OfferDetailsVM
	{
		public Offer Offer { get; set; } = new Offer();
		public Opinion Opinion { get; set; } = new Opinion();
		public List<Opinion> OpinionList { get; set; } = new List<Opinion>();
		public bool isCommented { get; set; } = false;
        public bool isOwner { get; set; } = false;
    }
}
