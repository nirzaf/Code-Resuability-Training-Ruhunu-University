using System.Collections.Generic;

namespace CodeReuseLibrary
{
    public interface IContentEvaluated
    {
        List<Evaluation> Evaluations { get; set; }
    }
}