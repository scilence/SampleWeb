//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;

using LinqToDB;
using LinqToDB.Mapping;

namespace SampleWeb.Models
{
	/// <summary>
	/// Database       : DBSample
	/// Data Source    : DBSample
	/// Server Version : 3.8.2
	/// </summary>
	public partial class DBSampleDB : LinqToDB.Data.DataConnection
	{
		public ITable<User> Users { get { return this.GetTable<User>(); } }

		public DBSampleDB()
		{
		}

		public DBSampleDB(string configuration)
			: base(configuration)
		{
		}
	}

	[Table("User")]
	public partial class User
	{
		[Column, Nullable] public string Account  { get; set; } // varchar(2147483647)
		[Column, Nullable] public string Password { get; set; } // varchar(2147483647)
		[Column, Nullable] public string Email    { get; set; } // varchar(2147483647)
	}
}