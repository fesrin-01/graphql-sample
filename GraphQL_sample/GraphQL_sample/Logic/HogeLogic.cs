using GraphQL_sample.Entities;

namespace GraphQL_sample.Logic
{
    public class HogeLogic
    {
        public static HogeResponce ReturnHoge()
        {
            HogeResponce hoges = new HogeResponce();
            {
                hoges.hoge1 = "hogehoge";
                hoges.hoge2 = "hogehoge2";
            }

            return hoges;
        }
    }
}
