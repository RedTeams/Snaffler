﻿using System.Collections.Generic;
using Classifiers;

namespace SnaffCore.Config
{
    public partial class Options
    {
        private void BuildFileDiscardClassifiers()
        {
            this.ClassifierRules.Add(
                new ClassifierRule()
                {
                    RuleOrder = 0,
                    RuleName = "DiscardExtExact",
                    EnumerationScope = EnumerationScope.FileEnumeration,
                    MatchLocation = MatchLoc.FileExtension,
                    WordListType = MatchListType.Exact,
                    MatchAction = MatchAction.Discard,
                    WordList = new List<string>()
                    {
                        // always skip these file extensions
                        // image formats
                        ".bmp",
                        ".eps",
                        ".gif",
                        ".ico",
                        ".jfi",
                        ".jfif",
                        ".jif",
                        ".jpe",
                        ".jpeg",
                        ".jpg",
                        ".png",
                        ".psd",
                        ".svg",
                        ".tif",
                        ".tiff",
                        ".webp",
                        ".xcf",
                        // fonts
                        ".ttf",
                        ".otf",
                        // misc
                        ".lock",
                        ".css",
                        ".less"
                    },
                });
        }
    }
}
