using KitX.Shared.Plugin;
using KitX.Shared.WebCommand;
using System;
using System.Collections.Generic;

namespace KitX.Contract.CSharp;

public interface IController
{
    void Start();

    void Pause();

    void End();

    List<Function> GetFunctions();

    void Execute(Command cmd);

    void SetRootPath(string path);

    void SetSendCommandAction(Action<Command> action);

    void SetWorkPath(string path);
}
