using GraphQL;
using GraphQL.Types;
using GraphQL_sample.GraphQL.Queries;

namespace GraphQL_sample.GraphQL.Schemas
{
    public class HogeSchema : Schema
    {
        public HogeSchema(IDependencyResolver dependencyResolver)
            : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<HogeQuery>();
        }
    }
}
