using GraphQL.Types;
using GraphQL_sample.GraphQL.Types;
using GraphQL_sample.Logic;

namespace GraphQL_sample.GraphQL.Queries
{
    public class HogeQuery : ObjectGraphType
    {
        public HogeQuery()
        {
            Field<HogeType>(
               "hogeQuery",
                   resolve: context =>
                   {
                       var hogeResponceValue = HogeLogic.ReturnHoge();
                       return hogeResponceValue;
                   });
        }
    }
}
