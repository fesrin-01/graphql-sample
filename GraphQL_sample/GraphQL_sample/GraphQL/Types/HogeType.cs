using GraphQL.Types;
using GraphQL_sample.Entities;

namespace GraphQL_sample.GraphQL.Types
{
    public class HogeType:ObjectGraphType<HogeResponce>
    {
        public HogeType()
        {
            Field(o => o.hoge1);
            Field(o => o.hoge2);
        }
    }
}
