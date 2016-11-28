using Nancy;
using System;
using System.Collections.Generic;
using Leetspeak.Objects;

namespace Leetspeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/results"] = _ =>{
        LeetspeakTranslator instance = new LeetspeakTranslator(Request.Form["input"]);
        string result = instance.Translate();

        return View["results.cshtml", result];
      };
    }
  }
}
