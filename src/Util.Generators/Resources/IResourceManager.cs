namespace Util.Generators.Resources {
    /// <summary>
    /// 静态资源管理器
    /// </summary>
    public interface IResourceManager {
        /// <summary>
        /// 导入静态资源
        /// </summary>
        /// <param name="templateRootPath">模板根目录路径</param>
        /// <param name="outputRootPath">输出根目录路径</param>
        /// <param name="project">项目名称</param>
        void Imports( string templateRootPath, string outputRootPath,string project );
    }
}
