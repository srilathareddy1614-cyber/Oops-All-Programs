//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;

//namespace Oops_All_Programs
//{
//    interface Iphonebasic
//    {
//        void calling();
//        void receiving();
//        void sendmsg();
//        void endcall(); 
//    }
//    class IphoneSE: Iphonebasic
//    {
//        public void calling()
//        {
//            Console.WriteLine("IphoneSE is Calling");
//        }
//        public void receiving()
//        {
//            Console.WriteLine("IphoneSE is Receiving");
//        }
//        public void sendmsg()
//        {
//            Console.WriteLine("IphoneSE is Sending Message");
//        }
//        public void endcall()
//        {
//            Console.WriteLine("IphoneSE is Ending Call");
//        }
//    }
//    interface Iphoneadvanced
//    {
//        void faceid();
//        void videocall();
//        void airdrop();
//    }
//    class Iphone16:Iphonebasic, Iphoneadvanced
//    {
//        public void calling()
//        {
//            Console.WriteLine("Iphone16 is Calling");
//        }
//        public void receiving()
//        {
//            Console.WriteLine("Iphone16 is Receiving");
//        }
//        public void sendmsg()
//        {
//            Console.WriteLine("Iphone16 is Sending Message");
//        }
//        public void endcall()
//        {
//            Console.WriteLine("Iphone16 is Ending Call");
//        }
//        public void faceid()
//        {
//            Console.WriteLine("Iphone16 is has FaceIDanuthenti");
//        }
//        public void videocall()
//        {
//            Console.WriteLine("Iphone16 is Making a Video Call");
//        }
//        public void airdrop()
//        {
//            Console.WriteLine("Iphone16 is Using AirDrop");
//        }
//    }

//    internal class MultipleInterface
//    {
//        static void Main(string[] args)
//        {
//            Iphonebasic obj= new IphoneSE();
//            obj.calling();
//            obj.receiving();
//            obj.sendmsg();
//            obj.endcall();
//            obj=new Iphone16();
//            obj.calling();
//            obj.receiving();
//            obj.sendmsg();
//            obj.endcall();
//            Iphoneadvanced obj1 = new Iphone16();
//            obj1.faceid();
//            obj1.videocall();
//            obj1.airdrop();
//        }
//    }
//}
