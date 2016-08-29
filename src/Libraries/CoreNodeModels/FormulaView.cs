using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using DSCore;
using CoreNodeModels.Properties;
using ProtoCore.AST.AssociativeAST;
using ProtoCore.Mirror;
using System.Globalization;

using Dynamo.Engine;
using Dynamo.Graph.Nodes;
using DynamoConversions;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public static class Utl
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static string returnString(string inputString)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
  {
    return inputString;
  }
}

namespace CoreNodeModels
{
    [IsDesignScriptCompatible]
    [NodeName("MathJax Formula View")]
    [NodeCategory("Core.View.Create")]
    [NodeDescription("Test MathJax")]
    [NodeSearchTags("MathJax")]

    [InPortNames("formulaIn")]
    [InPortTypes("string")]
    [InPortDescriptions("MathJax string")]
    [OutPortNames("formulaOut")]
    [OutPortTypes("string")]
    [OutPortDescriptions("MathJax string")]

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class FormulaView : NodeModel
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        private string formula = "$$ax^2+bx+c=0$$";
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string Formula
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
          get{ return formula; }
          set{
            formula = value;
            RaisePropertyChanged("Formula");
            OnNodeModified(false);
          }
        }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string GetFormula()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
          return Formula;
        }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public FormulaView()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            RegisterAllPorts();
        }
//#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
//    public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
//#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
//    {
//      if (!HasConnectedInput(0))
//      {
//        return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
//      }
//      //          Func<string> GetFormula =()=> formula; 
//      //var node = AstFactory.BuildFunctionCall(new Func<string, string>(Utl.returnString), inputAstNodes);
//      //var node = AstFactory.BuildFunctionCall("FormulaView", "GetFormula", inputAstNodes);
//      //var node = AstFactory.BuildFunctionCall(GetFormula, inputAstNodes);
//    
//      var node = AstFactory.BuildFunctionCall(
//                  new Func<string, string>(Conversions.retArg), inputAstNodes);
//      var assignment = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), node);
//          return new[] { assignment };
//        }
    }
}
