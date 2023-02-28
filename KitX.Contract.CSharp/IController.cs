using KitX.Web.Rules;
using System.Collections.Generic;

namespace KitX.Contract.CSharp
{
    public interface IController
    {

        /// <summary>
        /// 进入启动模式
        /// </summary>
        void Start();

        /// <summary>
        /// 进入暂停模式
        /// </summary>
        void Pause();

        /// <summary>
        /// 进入停止模式
        /// </summary>
        void End();

        /// <summary>
        /// 获取插件功能列表
        /// </summary>
        /// <returns>功能体</returns>
        List<Function> GetFunctions();

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="cmd">命令实例</param>
        void Execute(Command cmd);

        /// <summary>
        /// 设置根路径
        /// </summary>
        /// <param name="path"></param>
        void SetRootPath(string path);

        /// <summary>
        /// 设置插件的命令发送缓冲区
        /// </summary>
        /// <param name="commands">命令队列</param>
        void SetCommandsSendBuffer(ref Queue<Command> commands);

        /// <summary>
        /// 这是工作路径
        /// </summary>
        /// <param name="path"></param>
        void SetWorkPath(string path);
    }
}
