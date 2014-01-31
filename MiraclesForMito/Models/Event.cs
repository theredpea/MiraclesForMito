﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiraclesForMito.Models
{
	public class Event
	{
		public int ID { get; set; }

		/// <summary>
		/// The actual name of the event
		/// </summary>
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// The event description
		/// </summary>
		[Required]
		public string Description { get; set; }

		/// <summary>
		/// The start date of the event
		/// </summary>
		[Required]
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// The end date of the event.
		/// </summary>
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// The address of the event
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// City where the event is taking place
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// State where the event is taking place
		/// </summary>
		public string State { get; set; }

		/// <summary>
		/// Matching zip for city and state
		/// </summary>
		public string Zip { get; set; }

		/// <summary>
		/// Number to contact the organizer
		/// </summary>
		public string ContactNumber { get; set; }

		/// <summary>
		/// Person or company to contact
		/// </summary>
		public string ContactName { get; set; }

		/// <summary>
		/// Person or company's email to contact them at
		/// </summary>
		public string ContactEmail { get; set; }

		/// <summary>
		/// A Url to link people to.
		/// </summary>
		public string Link { get; set; }
	}
}