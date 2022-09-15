using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class listMobil
{
	public string IDRegistrasi { get; set; }
	public string Tipe { get; set; }
	public string Merk { get; set; }
	public string Varian { get; set; }
}

public class viewModelListMobil
{
	public string IDRegistrasi { get; set; }
	public string Merk { get; set; }
	public string Varian { get; set; }
}


public class Program
{
	public static void Main()
	{
		IEnumerable<listMobil> ListMobil = new listMobil[] {
			new listMobil { IDRegistrasi = "0001", Tipe = "Sedan", Merk = "Toyota", Varian= "FT86"},
			new listMobil { IDRegistrasi = "0002", Tipe = "SUV", Merk = "Toyota", Varian = "RAV4" },
			new listMobil { IDRegistrasi = "0003", Tipe = "Sedan", Merk = "Honda", Varian = "Accord"},
			new listMobil { IDRegistrasi = "0004", Tipe = "SUV", Merk = "Honda", Varian = "CRV"},
			new listMobil { IDRegistrasi = "0005", Tipe = "Sedan", Merk = "Honda", Varian = "City" },
		};

		//1. Tampilkan data pertama yang memiliki merk "Honda"
		var ListMerkHonda = ListMobil.Where(mobil => mobil.Merk == "Honda").Select(p => new viewModelListMobil()
		{
			IDRegistrasi = p.IDRegistrasi,
			Merk = p.Merk,
			Varian = p.Varian
		}).ToList();

		//2. Tampilkan data terakhir yang memiliki merk "Honda" dan bertipe "Sedan"
		var ListMerkHondaAndTypeSedan = ListMobil.Where(mobil => mobil.Merk == "Honda" && mobil.Tipe == "Sedan").Select(p => new viewModelListMobil()
		{
			IDRegistrasi = p.IDRegistrasi,
			Merk = p.Merk,
			Varian = p.Varian
		}).ToList();
		//3. Tampilkan data pertama yang memiliki merk "Honda" dan punya varian "City"
		var ListMerkHondaAndVarianCity = ListMobil.Where(mobil => mobil.Merk == "Honda" && mobil.Varian == "City").Select(p => new viewModelListMobil()
		{
			IDRegistrasi = p.IDRegistrasi,
			Merk = p.Merk,
			Varian = p.Varian
		}).ToList();
		//4. Tampilkan data default yang memiliki merk "Toyota"
		var ListMerkToyota = ListMobil.Where(mobil => mobil.Merk == "Toyota").Select(p => new viewModelListMobil()
		{
			IDRegistrasi = p.IDRegistrasi,
			Merk = p.Merk,
			Varian = p.Varian
		}).ToList();
		//5. Tampilkan 3 data apa saja
		var ListData = ListMobil.Take(3).Select(p => new viewModelListMobil()
		{
			IDRegistrasi = p.IDRegistrasi,
			Merk = p.Merk,
			Varian = p.Varian
		}).ToList();
		var collection = new Dictionary<string, object>();
		collection.Add("Soal1", ListMerkHonda);
		collection.Add("Soal2", ListMerkHondaAndTypeSedan);
		collection.Add("Soal3", ListMerkHondaAndVarianCity);
		collection.Add("Soal4", ListMerkToyota);
		collection.Add("Soal5", ListData);


		var result = JsonConvert.SerializeObject(collection);

		Console.WriteLine(result);
	}
}
