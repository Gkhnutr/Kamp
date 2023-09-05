using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager esnafKredisiManager = new EsnafKredisiManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, smsLoggerService };

BasvuruManager basvuruManager = new BasvuruManager();

basvuruManager.BasvuruYap(esnafKredisiManager,loggers);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);