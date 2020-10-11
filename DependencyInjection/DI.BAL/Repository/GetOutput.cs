using System;
using DI.BAL.UnitOfWork;

namespace DI.BAL.Repository
{
    public class GetOutput : IGetOutput
    {
        string IGetOutput.GetOutput(string InputType)
        {
            string Output;
            switch (InputType)
            {
                case "Database":
                    GetOutputFromDatabase DBObj = new GetOutputFromDatabase();
                    Output = DBObj.DatabaseCall();
                    break;
                default:
                    GetOutputFromFileSystem FSObj = new GetOutputFromFileSystem();
                    Output = FSObj.FileSystemCall();
                    break;

            }
            return Output;
        }
    }
}
