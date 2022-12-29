package org.crequency.kitx.contracts.java;

import org.crequency.kitx.ruls.web.Function;

import java.util.ArrayList;

public interface IController {
    void Start();

    void Pause();

    void End();

    ArrayList<Function> GetFunctions();

    Object Execute(String cmd);

    Object Execute(String cmd, Object arg);

    void SetRootPath(String path);

    void SetWorkPath(String path);
}
