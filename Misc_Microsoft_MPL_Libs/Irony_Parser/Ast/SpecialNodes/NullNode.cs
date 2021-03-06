﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Parsing;
using Irony.Interpreter;

namespace Irony.Ast {
  //A stub to use when AST node was not created (type not specified on NonTerminal, or error on creation)
  // The purpose of the stub is to throw a meaningful message when interpreter tries to evaluate null node.
  public class NullNode : AstNode {

    public NullNode(BnfTerm term) {
      this.Term = term; 
    }
        
    public override void Evaluate(EvaluationContext context, AstMode mode) {
      context.ThrowError(O2_Misc_Microsoft_MPL_Libs.Irony_Parser.Resources.ErrNullNodeEval, this.Term);  
    }
  }//class
}
