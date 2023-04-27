using Bridge;

TVFactory tVFactory= new TVFactory();
SpecialRemote remoteSony = new SpecialRemote(tVFactory);
Console.WriteLine("Connect your remote to the TV");
remoteSony.setTV("Sony");
remoteSony.on();
remoteSony.up();
remoteSony.down();
remoteSony.off();

GenericRemote remoteLG = new GenericRemote(tVFactory);
Console.WriteLine("Connect your remote to the TV");
remoteLG.setTV("LG");
remoteLG.on();
remoteLG.nextChannel();
remoteLG.prevChannel();
remoteLG.off();
