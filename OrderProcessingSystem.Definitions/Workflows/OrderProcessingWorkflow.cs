using OrderProcessingSystem.Definitions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temporalio.Workflows;

namespace OrderProcessingSystem.Definitions.Workflows
{
    [Workflow]
    public class OrderProcessingWorkflow
    {
        [WorkflowRun]
        public async Task Run(CustomerOrder order)
        {


        }
    }
}
