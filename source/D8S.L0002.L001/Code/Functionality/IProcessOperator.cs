using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using R5T.T0132;


namespace D8S.L0002.L001
{
    [FunctionalityMarker]
    public partial interface IProcessOperator : IFunctionalityMarker,
        R5T.L0066.IProcessOperator
    {
        public void DataReceivedEventHandler_Console(object sender, DataReceivedEventArgs dataReceived)
            => Console.WriteLine(dataReceived.Data);

        public DataReceivedEventHandler Get_DataReceivedEventHandler(
            out List<string> accumulator)
        {
            accumulator = new List<string>();

            var output = this.Get_DataReceivedEventHandler(
                accumulator);

            return output;
        }

        /// <inheritdoc cref="R5T.Y0006.Documentation.For_Get_DataReceivedEventArgs"/>
        public DataReceivedEventHandler Get_DataReceivedEventHandler(
            List<string> accumulator,
            Func<string, bool> filter)
        {
            void Internal(object sender, DataReceivedEventArgs dataReceived)
            {
                var data = dataReceived.Data;

                var include = filter(data);

                if (include)
                {
                    accumulator.Add(data);
                }
            }

            return Internal;
        }

        public DataReceivedEventHandler Get_DataReceivedEventHandler_Console()
            => this.DataReceivedEventHandler_Console;

        public DataReceivedEventHandler Get_DataReceivedEventHandler_Default(
            out List<string> accumulator)
        {
            var output_ToAccumulator = this.Get_DataReceivedEventHandler(
                out accumulator);

            var output_ToConsole = this.Get_DataReceivedEventHandler_Console();

            var output = this.Get_DataReceivedEventHandler_Aggregate(
                output_ToAccumulator,
                output_ToConsole);

            return output;
        }
    }
}
