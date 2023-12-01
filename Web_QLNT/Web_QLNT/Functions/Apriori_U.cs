using Accord.MachineLearning.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_QLNT.Models;

namespace Web_QLNT.Functions
{
    public class Apriori_U
    {
        public Apriori_U()
        {

        }

        public AssociationRule<string>[] doApriori(List<CToHD> ct)
        {
            string[][] dataset = new string[50][];
            int i = 0;
            //{
            //    new string[] { "1", "2", "5" },
            //    new string[] { "2", "4" },
            //    new string[] { "2", "3" },
            //    new string[] { "1", "2", "4" },
            //    new string[] { "1", "3" },
            //    new string[] { "2", "3" },
            //    new string[] { "1", "3" },
            //    new string[] { "1", "2", "3", "5" },
            //    new string[] { "1", "2", "3" },
            //};
            foreach (CToHD item in ct)
            {
                dataset[i] = item.layCTHD();
            }

            // Create a new A-priori learning algorithm with the requirements
            var apriori = new Apriori<string>(threshold: 2, confidence: 0.7);

            // Use apriori to generate a n-itemset generation frequent pattern
            AssociationRuleMatcher<string> classifier = apriori.Learn(dataset);

            // Generate association rules from the itemsets:
            AssociationRule<string>[] rules = classifier.Rules;
            return rules;
        }
    }
}