package org.crequency.kitx.contracts.java;

public interface IController {
    void Start();

    void Pause();

    void End();

//    List<Function> GetFunctions();

    Object Execute(String cmd);

    Object Execute(String cmd, Object arg);

    void SetRootPath(String path);

    void SetWorkPath(String path);
}
