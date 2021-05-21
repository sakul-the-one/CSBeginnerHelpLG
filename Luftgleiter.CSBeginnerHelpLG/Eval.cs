using Microsoft.CSharp;
using Microsoft.JScript;
using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luftgleiter.CSBeginnerHelpLG
{
    public class Eval
    {
        public static object CSEval(string CSCode, string Output, List<string> Assemblies)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            foreach (string s in Assemblies)
            {
                parameters.ReferencedAssemblies.Add(s);
            }
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, CSCode);
            if (results.Errors.Count > 0)
            {
                string Errors = string.Empty;
                foreach (CompilerError CompErr in results.Errors)
                {
                    Errors += "Line number " + CompErr.Line +
                        ", Error Number: " + CompErr.ErrorNumber +
                        ", '" + CompErr.ErrorText + ";" +
                        Environment.NewLine + Environment.NewLine;
                }
                return Errors;
            }
            else
            {
                Process.Start(Output);
                return "Succes!";
            }
        }
        public static object JSEval(string JSCode, string Output, List<string> Assemblies)
        {

            JScriptCodeProvider codeProvider = new JScriptCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            foreach (string s in Assemblies)
            {
                parameters.ReferencedAssemblies.Add(s);
            }
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, JSCode);
            if (results.Errors.Count > 0)
            {
                string Errors = string.Empty;
                foreach (CompilerError CompErr in results.Errors)
                {
                    Errors += "Line number " + CompErr.Line +
                        ", Error Number: " + CompErr.ErrorNumber +
                        ", '" + CompErr.ErrorText + ";" +
                        Environment.NewLine + Environment.NewLine;
                }
                return Errors;
            }
            else
            {
                
                Process.Start(Output);
                return "Succes!";
            }
        }
        public static object VBEval(string VBCode,string Output, List<string> Assemblies)
        {
            VBCodeProvider codeProvider = new VBCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            foreach (string s in Assemblies)
            {
                parameters.ReferencedAssemblies.Add(s);
            }
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, VBCode);
            if (results.Errors.Count > 0)
            {
                string Errors = string.Empty;
                foreach (CompilerError CompErr in results.Errors)
                {
                    Errors += "Line number " + CompErr.Line +
                        ", Error Number: " + CompErr.ErrorNumber +
                        ", '" + CompErr.ErrorText + ";" +
                        Environment.NewLine + Environment.NewLine;
                }
                return Errors;
            }
            else
            {
                Process.Start(Output);
                return "Succes!";
            }

        }

    }
}
