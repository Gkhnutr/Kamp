﻿using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Engin";
musteri1.Soyadi = "Demiroğ";
musteri1.TcNo = "12345";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "12345";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "12345";

CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri1);
customerManager.Add(musteri2);
