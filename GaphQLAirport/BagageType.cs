using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriBagageApp;

namespace GraphQLAirport
{
    public class BagageType : ObjectGraphType<Bagage>
    {
        public BagageType() {
            Field(b => b.Id, type: typeof(IdGraphType)).Description("Clé primaire de Bagage");
            Field(b => b.VolId, type: typeof(IdGraphType)).Description("Id du vol auquel le bagage est rattaché");
            Field(b => b.CodeIATA, type: typeof(IdGraphType)).Description("Code du bagage");
            Field(b => b.Poids, type: typeof(IdGraphType)).Description("Poids du bagage");

        }
    }
}
