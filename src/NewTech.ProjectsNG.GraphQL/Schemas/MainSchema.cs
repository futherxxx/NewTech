using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using NewTech.ProjectsNG.Queries.Container;

namespace NewTech.ProjectsNG.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}