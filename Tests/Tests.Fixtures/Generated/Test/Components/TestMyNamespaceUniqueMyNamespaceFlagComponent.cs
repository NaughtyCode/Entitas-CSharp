//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestContext {

    public TestEntity myNamespaceUniqueMyNamespaceFlagEntity { get { return GetGroup(TestMatcher.MyNamespaceUniqueMyNamespaceFlag).GetSingleEntity(); } }

    public bool isMyNamespaceUniqueMyNamespaceFlag {
        get { return myNamespaceUniqueMyNamespaceFlagEntity != null; }
        set {
            var entity = myNamespaceUniqueMyNamespaceFlagEntity;
            if(value != (entity != null)) {
                if(value) {
                    CreateEntity().isMyNamespaceUniqueMyNamespaceFlag = true;
                } else {
                    DestroyEntity(entity);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly My.Namespace.UniqueMyNamespaceFlagComponent myNamespaceUniqueMyNamespaceFlagComponent = new My.Namespace.UniqueMyNamespaceFlagComponent();

    public bool isMyNamespaceUniqueMyNamespaceFlag {
        get { return HasComponent(TestComponentsLookup.MyNamespaceUniqueMyNamespaceFlag); }
        set {
            if(value != isMyNamespaceUniqueMyNamespaceFlag) {
                if(value) {
                    AddComponent(TestComponentsLookup.MyNamespaceUniqueMyNamespaceFlag, myNamespaceUniqueMyNamespaceFlagComponent);
                } else {
                    RemoveComponent(TestComponentsLookup.MyNamespaceUniqueMyNamespaceFlag);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherMyNamespaceUniqueMyNamespaceFlag;

    public static Entitas.IMatcher<TestEntity> MyNamespaceUniqueMyNamespaceFlag {
        get {
            if(_matcherMyNamespaceUniqueMyNamespaceFlag == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.MyNamespaceUniqueMyNamespaceFlag);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherMyNamespaceUniqueMyNamespaceFlag = matcher;
            }

            return _matcherMyNamespaceUniqueMyNamespaceFlag;
        }
    }
}
