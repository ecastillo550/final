﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Libreria
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::Libreria.Libreria_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Libreria.Libreria_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.String fullName)
        {
            if(_provider == null)
            {
                _provider = new global::Libreria.Libreria_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace Libreria.Libreria_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            string standardName;
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (global::System.String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (global::System.String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType> _xamlTypes = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();
        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember> _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();
        global::System.Collections.Generic.Dictionary<global::System.Type, string> _xamlTypeToStandardName = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

        private void AddToMapOfTypeToStandardName(global::System.Type t, global::System.String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_LayoutAwarePage() { return new global::Libreria.Common.LayoutAwarePage(); }

        private object Activate_1_GroupedItemsPage() { return new global::Libreria.GroupedItemsPage(); }

        private object Activate_2_GroupDetailPage() { return new global::Libreria.GroupDetailPage(); }

        private object Activate_3_RichTextColumns() { return new global::Libreria.Common.RichTextColumns(); }

        private object Activate_4_ItemDetailPage() { return new global::Libreria.ItemDetailPage(); }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(string typeName)
        {
            global::Libreria.Libreria_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Libreria.Libreria_XamlTypeInfo.XamlUserType userType;

            switch (typeName)
            {
            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new global::Libreria.Libreria_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Page));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new global::Libreria.Libreria_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.UserControl));
                break;

            case "Windows.UI.Xaml.Controls.Panel":
                xamlType = new global::Libreria.Libreria_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Panel));
                break;

            case "Windows.UI.Xaml.Controls.RichTextBlock":
                xamlType = new global::Libreria.Libreria_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.RichTextBlock));
                break;

            case "Windows.UI.Xaml.DataTemplate":
                xamlType = new global::Libreria.Libreria_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.DataTemplate));
                break;

            case "Libreria.Common.LayoutAwarePage":
                userType = new global::Libreria.Libreria_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::Libreria.Common.LayoutAwarePage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_LayoutAwarePage;
                xamlType = userType;
                break;

            case "Libreria.GroupedItemsPage":
                userType = new global::Libreria.Libreria_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::Libreria.GroupedItemsPage), GetXamlTypeByName("Libreria.Common.LayoutAwarePage"));
                userType.Activator = Activate_1_GroupedItemsPage;
                xamlType = userType;
                break;

            case "Libreria.GroupDetailPage":
                userType = new global::Libreria.Libreria_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::Libreria.GroupDetailPage), GetXamlTypeByName("Libreria.Common.LayoutAwarePage"));
                userType.Activator = Activate_2_GroupDetailPage;
                xamlType = userType;
                break;

            case "Libreria.Common.RichTextColumns":
                userType = new global::Libreria.Libreria_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::Libreria.Common.RichTextColumns), GetXamlTypeByName("Windows.UI.Xaml.Controls.Panel"));
                userType.Activator = Activate_3_RichTextColumns;
                userType.SetContentPropertyName("Libreria.Common.RichTextColumns.RichTextContent");
                userType.AddMemberName("RichTextContent");
                userType.AddMemberName("ColumnTemplate");
                xamlType = userType;
                break;

            case "Libreria.ItemDetailPage":
                userType = new global::Libreria.Libreria_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::Libreria.ItemDetailPage), GetXamlTypeByName("Libreria.Common.LayoutAwarePage"));
                userType.Activator = Activate_4_ItemDetailPage;
                xamlType = userType;
                break;

            }
            return xamlType;
        }


        private object get_0_RichTextColumns_RichTextContent(object instance)
        {
            var that = (global::Libreria.Common.RichTextColumns)instance;
            return that.RichTextContent;
        }
        private void set_0_RichTextColumns_RichTextContent(object instance, object Value)
        {
            var that = (global::Libreria.Common.RichTextColumns)instance;
            that.RichTextContent = (global::Windows.UI.Xaml.Controls.RichTextBlock)Value;
        }
        private object get_1_RichTextColumns_ColumnTemplate(object instance)
        {
            var that = (global::Libreria.Common.RichTextColumns)instance;
            return that.ColumnTemplate;
        }
        private void set_1_RichTextColumns_ColumnTemplate(object instance, object Value)
        {
            var that = (global::Libreria.Common.RichTextColumns)instance;
            that.ColumnTemplate = (global::Windows.UI.Xaml.DataTemplate)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Libreria.Libreria_XamlTypeInfo.XamlMember xamlMember = null;
            global::Libreria.Libreria_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Libreria.Common.RichTextColumns.RichTextContent":
                userType = (global::Libreria.Libreria_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Libreria.Common.RichTextColumns");
                xamlMember = new global::Libreria.Libreria_XamlTypeInfo.XamlMember(this, "RichTextContent", "Windows.UI.Xaml.Controls.RichTextBlock");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_RichTextColumns_RichTextContent;
                xamlMember.Setter = set_0_RichTextColumns_RichTextContent;
                break;
            case "Libreria.Common.RichTextColumns.ColumnTemplate":
                userType = (global::Libreria.Libreria_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Libreria.Common.RichTextColumns");
                xamlMember = new global::Libreria.Libreria_XamlTypeInfo.XamlMember(this, "ColumnTemplate", "Windows.UI.Xaml.DataTemplate");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_RichTextColumns_ColumnTemplate;
                xamlMember.Setter = set_1_RichTextColumns_ColumnTemplate;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(global::System.String input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::Libreria.Libreria_XamlTypeInfo.XamlSystemBaseType
    {
        global::Libreria.Libreria_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::Libreria.Libreria_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public global::System.Object CreateFromString(global::System.String input)
        {
            if (_enumValues != null)
            {
                global::System.Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    global::System.Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( global::System.String.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::Libreria.Libreria_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Libreria.Libreria_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(global::System.String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


