// An interface for all poolable objects
public interface IPoolable {

    // This method has to be defined in a component that
    // has properties that require resetting upon reuse
    void OnReuse();

    void OnReuseWithArguments(params object[] list);

}
