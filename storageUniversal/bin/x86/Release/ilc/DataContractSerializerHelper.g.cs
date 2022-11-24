using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<string, global::System.Type> wcfSerializers = global::System.Runtime.Serialization.GeneratedXmlSerializers.GetGeneratedSerializers();
            PopulateWcfSerializerDictionary(wcfSerializers);
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 88
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                5, // array length: 5
                581, // index: 581, string: "HelpLink"
                590, // index: 590, string: "InnerException"
                605, // index: 605, string: "Message"
                613, // index: 613, string: "StackTrace"
                624, // index: 624, string: "Type"
                5, // array length: 5
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                629, // index: 629, string: "Body"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                1, // array length: 1
                634, // index: 634, string: "HelloWorldResult"
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                629, // index: 629, string: "Body"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                629, // index: 629, string: "Body"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                1, // array length: 1
                651, // index: 651, string: "AddLendingResult"
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                1, // array length: 1
                629, // index: 629, string: "Body"
                1, // array length: 1
                350, // index: 350, string: "http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                439, // index: 439, string: "http://tempuri.org/"
                4, // array length: 4
                668, // index: 668, string: "itemId"
                675, // index: 675, string: "lentForWho"
                686, // index: 686, string: "whenBorowwed"
                699, // index: 699, string: "amountBorowwed"
                4, // array length: 4
                439, // index: 439, string: "http://tempuri.org/"
                439, // index: 439, string: "http://tempuri.org/"
                439, // index: 439, string: "http://tempuri.org/"
                439  // index: 439, string: "http://tempuri.org/"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=46
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Private.Xml, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd" +
                                "51")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.5.0.4, Culture=neutral, PublicKeyTok" +
                                "en=b03f5f7f11d50a3a")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldResponseBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                "oken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldRequestBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                "ken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingResponseBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                "oken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingRequestBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                "ken=null")),
                    TableIndex = 129, // 0x81
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Private.Xml, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd" +
                                    "51")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Private.Xml, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd" +
                                    "51")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=9
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // ExceptionDetail
                        NamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        StableNameIndex = 255, // ExceptionDetail
                        StableNameNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        TopLevelElementNameIndex = 255, // ExceptionDetail
                        TopLevelElementNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.5.0.4, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.5.0.4, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadExceptionDetailFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteExceptionDetailToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 7,
                    MemberNamesListIndex = 9,
                    MemberNamespacesListIndex = 15,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 331, // HelloWorldResponse
                        NamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        StableNameIndex = 331, // HelloWorldResponse
                        StableNameNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        TopLevelElementNameIndex = 331, // HelloWorldResponse
                        TopLevelElementNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type2.ReadHelloWorldResponseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type3.WriteHelloWorldResponseToXml),
                    ChildElementNamespacesListIndex = 21,
                    ContractNamespacesListIndex = 23,
                    MemberNamesListIndex = 25,
                    MemberNamespacesListIndex = 27,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 416, // HelloWorldResponseBody
                        NamespaceIndex = 439, // http://tempuri.org/
                        StableNameIndex = 416, // HelloWorldResponseBody
                        StableNameNamespaceIndex = 439, // http://tempuri.org/
                        TopLevelElementNameIndex = 416, // HelloWorldResponseBody
                        TopLevelElementNamespaceIndex = 439, // http://tempuri.org/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldResponseBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldResponseBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type4.ReadHelloWorldResponseBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type5.WriteHelloWorldResponseBodyToXml),
                    ChildElementNamespacesListIndex = 29,
                    ContractNamespacesListIndex = 31,
                    MemberNamesListIndex = 33,
                    MemberNamespacesListIndex = 35,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 459, // HelloWorldRequest
                        NamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        StableNameIndex = 459, // HelloWorldRequest
                        StableNameNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        TopLevelElementNameIndex = 459, // HelloWorldRequest
                        TopLevelElementNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type6.ReadHelloWorldRequestFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type7.WriteHelloWorldRequestToXml),
                    ChildElementNamespacesListIndex = 37,
                    ContractNamespacesListIndex = 39,
                    MemberNamesListIndex = 41,
                    MemberNamespacesListIndex = 43,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 477, // HelloWorldRequestBody
                        NamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        StableNameIndex = 477, // HelloWorldRequestBody
                        StableNameNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        TopLevelElementNameIndex = 477, // HelloWorldRequestBody
                        TopLevelElementNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldRequestBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.HelloWorldRequestBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type8.ReadHelloWorldRequestBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type9.WriteHelloWorldRequestBodyToXml),
                    ContractNamespacesListIndex = 45,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 499, // AddLendingResponse
                        NamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        StableNameIndex = 499, // AddLendingResponse
                        StableNameNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        TopLevelElementNameIndex = 499, // AddLendingResponse
                        TopLevelElementNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type10.ReadAddLendingResponseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type11.WriteAddLendingResponseToXml),
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 49,
                    MemberNamesListIndex = 51,
                    MemberNamespacesListIndex = 53,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 518, // AddLendingResponseBody
                        NamespaceIndex = 439, // http://tempuri.org/
                        StableNameIndex = 518, // AddLendingResponseBody
                        StableNameNamespaceIndex = 439, // http://tempuri.org/
                        TopLevelElementNameIndex = 518, // AddLendingResponseBody
                        TopLevelElementNamespaceIndex = 439, // http://tempuri.org/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingResponseBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingResponseBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type12.ReadAddLendingResponseBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type13.WriteAddLendingResponseBodyToXml),
                    ChildElementNamespacesListIndex = 55,
                    ContractNamespacesListIndex = 57,
                    MemberNamesListIndex = 59,
                    MemberNamespacesListIndex = 61,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 541, // AddLendingRequest
                        NamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        StableNameIndex = 541, // AddLendingRequest
                        StableNameNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        TopLevelElementNameIndex = 541, // AddLendingRequest
                        TopLevelElementNamespaceIndex = 350, // http://schemas.datacontract.org/2004/07/storageUniversal.BorowwDb
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type14.ReadAddLendingRequestFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type15.WriteAddLendingRequestToXml),
                    ChildElementNamespacesListIndex = 63,
                    ContractNamespacesListIndex = 65,
                    MemberNamesListIndex = 67,
                    MemberNamespacesListIndex = 69,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 559, // AddLendingRequestBody
                        NamespaceIndex = 439, // http://tempuri.org/
                        StableNameIndex = 559, // AddLendingRequestBody
                        StableNameNamespaceIndex = 439, // http://tempuri.org/
                        TopLevelElementNameIndex = 559, // AddLendingRequestBody
                        TopLevelElementNamespaceIndex = 439, // http://tempuri.org/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingRequestBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("storageUniversal.BorowwDb.AddLendingRequestBody, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type16.ReadAddLendingRequestBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type17.WriteAddLendingRequestBodyToXml),
                    ChildElementNamespacesListIndex = 71,
                    ContractNamespacesListIndex = 76,
                    MemberNamesListIndex = 78,
                    MemberNamespacesListIndex = 83,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[0];
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_wcfSerializerEntryList_Hashtable = null;
        // Count=36
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::WcfSerializerEntry[] s_wcfSerializerEntryList = new global::WcfSerializerEntry[] {
                new global::WcfSerializerEntry() {
                    Key = 714, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.String] HelloWorldAsync():Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemStringHelloWorldAsyncRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 828, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.String] HelloWorldAsync():Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemStringHelloWorldAsyncResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 943, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] regAsync(storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanregAsyncstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 1083, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] regAsync(storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanregAsyncstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 1224, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] IsUserPermittedAsync(storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanIsUserPermittedAsyncstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 1376, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] IsUserPermittedAsync(storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanIsUserPermittedAsyncstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 1529, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Int32] AddEmptyUserAsync():Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemInt32AddEmptyUserAsyncRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 1644, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Int32] AddEmptyUserAsync():Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemInt32AddEmptyUserAsyncResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 1760, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[storageUniversal.UserDBServ.User] GetFullUserAsync(storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1storageUniversalUserDBServUserGetFullUserAsyncstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 1926, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[storageUniversal.UserDBServ.User] GetFullUserAsync(storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1storageUniversalUserDBServUserGetFullUserAsyncstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 2093, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] updateUserByIdAsync(storageUniversal.UserDBServ.User, storageUniversal.UserDBServ.User, Int32):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanupdateUserByIdAsyncstorageUniversalUserDBServUserstorageUniversalUserDBServUserInt32Request).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 2285, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] updateUserByIdAsync(storageUniversal.UserDBServ.User, storageUniversal.UserDBServ.User, Int32):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanupdateUserByIdAsyncstorageUniversalUserDBServUserstorageUniversalUserDBServUserInt32Response).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 2478, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] updateUserByIdAdminAsync(Int32, storageUniversal.UserDBServ.User, storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanupdateUserByIdAdminAsyncInt32storageUniversalUserDBServUserstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 2675, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] updateUserByIdAdminAsync(Int32, storageUniversal.UserDBServ.User, storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanupdateUserByIdAdminAsyncInt32storageUniversalUserDBServUserstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 2873, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] updateUserAsync(storageUniversal.UserDBServ.User, storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanupdateUserAsyncstorageUniversalUserDBServUserstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 3054, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] updateUserAsync(storageUniversal.UserDBServ.User, storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanupdateUserAsyncstorageUniversalUserDBServUserstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 3236, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] DeleteUserAsync(storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanDeleteUserAsyncstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 3383, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] DeleteUserAsync(storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanDeleteUserAsyncstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 3531, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] DeleteUserAdminAsync(storageUniversal.UserDBServ.User, Int32):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanDeleteUserAdminAsyncstorageUniversalUserDBServUserInt32Request).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 3690, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] DeleteUserAdminAsync(storageUniversal.UserDBServ.User, Int32):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanDeleteUserAdminAsyncstorageUniversalUserDBServUserInt32Response).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 3850, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] IsAdminAsync(storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanIsAdminAsyncstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 3994, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[System.Boolean] IsAdminAsync(storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1SystemBooleanIsAdminAsyncstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 4139, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult] GetAdminUserTblAsync(storageUniversal.UserDBServ.User):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1storageUniversalUserDBServGetAdminUserTblResponseGetAdminUserTblResultGetAdminUserTblAsyncstorageUniversalUserDBServUserRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 4349, // storageUniversal.UserDBServ.UserDBServSoap:System.Threading.Tasks.Task`1[storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult] GetAdminUserTblAsync(storageUniversal.UserDBServ.User):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalUserDBServUserDBServSoapSystemThreadingTasksTask1storageUniversalUserDBServGetAdminUserTblResponseGetAdminUserTblResultGetAdminUserTblAsyncstorageUniversalUserDBServUserResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 4560, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.String] HelloWorldAsync():Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemStringHelloWorldAsyncRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 4681, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.String] HelloWorldAsync():Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemStringHelloWorldAsyncResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 4803, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[storageUniversal.InventoryServ.GetInventoryDataTableResponseGetInventoryDataTableResult] GetInventoryDataTableAsync():Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1storageUniversalInventoryServGetInventoryDataTableResponseGetInventoryDataTableResultGetInventoryDataTableAsyncRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 5009, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[storageUniversal.InventoryServ.GetInventoryDataTableResponseGetInventoryDataTableResult] GetInventoryDataTableAsync():Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1storageUniversalInventoryServGetInventoryDataTableResponseGetInventoryDataTableResultGetInventoryDataTableAsyncResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 5216, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[storageUniversal.InventoryServ.GetInventoryUserDataTableResponseGetInventoryUserDataTableResult] GetInventoryUserDataTableAsync(Int32):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1storageUniversalInventoryServGetInventoryUserDataTableResponseGetInventoryUserDataTableResultGetInventoryUserDataTableAsyncInt32Request).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 5439, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[storageUniversal.InventoryServ.GetInventoryUserDataTableResponseGetInventoryUserDataTableResult] GetInventoryUserDataTableAsync(Int32):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1storageUniversalInventoryServGetInventoryUserDataTableResponseGetInventoryUserDataTableResultGetInventoryUserDataTableAsyncInt32Response).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 5663, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.Boolean] changeInventoryRowAsync(storageUniversal.InventoryServ.InventoryRow):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemBooleanchangeInventoryRowAsyncstorageUniversalInventoryServInventoryRowRequest).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 5836, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.Boolean] changeInventoryRowAsync(storageUniversal.InventoryServ.InventoryRow):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemBooleanchangeInventoryRowAsyncstorageUniversalInventoryServInventoryRowResponse).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 6010, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.Boolean] DeleteInventoryRowAsync(Int32):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemBooleanDeleteInventoryRowAsyncInt32Request).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 6145, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.Boolean] DeleteInventoryRowAsync(Int32):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemBooleanDeleteInventoryRowAsyncInt32Response).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 6281, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.Int32] getNewItemIdAsync(Int32):Request
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemInt32getNewItemIdAsyncInt32Request).TypeHandle),
                }, 
                new global::WcfSerializerEntry() {
                    Key = 6408, // storageUniversal.InventoryServ.InventoryFuncsSoap:System.Threading.Tasks.Task`1[System.Int32] getNewItemIdAsync(Int32):Response
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(typeof(global::Microsoft.Xml.Serialization.GeneratedAssembly.storageUniversalInventoryServInventoryFuncsSoapSystemThreadingTasksTask1SystemInt32getNewItemIdAsyncInt32Response).TypeHandle),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','E','x','c','e','p','t','i','o','n','D','e','t','a','i','l',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','.','S','e','r','v','i','c','e','M','o','d','e','l',
            '\0','H','e','l','l','o','W','o','r','l','d','R','e','s','p','o','n','s','e','\0','h','t','t','p',':','/','/','s','c','h',
            'e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/',
            's','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','B','o','r','o','w','w','D','b','\0','H','e','l','l',
            'o','W','o','r','l','d','R','e','s','p','o','n','s','e','B','o','d','y','\0','h','t','t','p',':','/','/','t','e','m','p',
            'u','r','i','.','o','r','g','/','\0','H','e','l','l','o','W','o','r','l','d','R','e','q','u','e','s','t','\0','H','e','l',
            'l','o','W','o','r','l','d','R','e','q','u','e','s','t','B','o','d','y','\0','A','d','d','L','e','n','d','i','n','g','R',
            'e','s','p','o','n','s','e','\0','A','d','d','L','e','n','d','i','n','g','R','e','s','p','o','n','s','e','B','o','d','y',
            '\0','A','d','d','L','e','n','d','i','n','g','R','e','q','u','e','s','t','\0','A','d','d','L','e','n','d','i','n','g','R',
            'e','q','u','e','s','t','B','o','d','y','\0','H','e','l','p','L','i','n','k','\0','I','n','n','e','r','E','x','c','e','p',
            't','i','o','n','\0','M','e','s','s','a','g','e','\0','S','t','a','c','k','T','r','a','c','e','\0','T','y','p','e','\0','B',
            'o','d','y','\0','H','e','l','l','o','W','o','r','l','d','R','e','s','u','l','t','\0','A','d','d','L','e','n','d','i','n',
            'g','R','e','s','u','l','t','\0','i','t','e','m','I','d','\0','l','e','n','t','F','o','r','W','h','o','\0','w','h','e','n',
            'B','o','r','o','w','w','e','d','\0','a','m','o','u','n','t','B','o','r','o','w','w','e','d','\0','s','t','o','r','a','g',
            'e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e',
            'r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.',
            'T','a','s','k','`','1','[','S','y','s','t','e','m','.','S','t','r','i','n','g',']',' ','H','e','l','l','o','W','o','r',
            'l','d','A','s','y','n','c','(',')',':','R','e','q','u','e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e',
            'r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',
            ':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1',
            '[','S','y','s','t','e','m','.','S','t','r','i','n','g',']',' ','H','e','l','l','o','W','o','r','l','d','A','s','y','n',
            'c','(',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.',
            'U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t',
            'e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t',
            'e','m','.','B','o','o','l','e','a','n',']',' ','r','e','g','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n',
            'i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','q','u','e',
            's','t','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v',
            '.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i',
            'n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',
            ']',' ','r','e','g','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s',
            'e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g',
            'e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e',
            'r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.',
            'T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','I','s','U','s','e','r','P',
            'e','r','m','i','t','t','e','d','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l',
            '.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','q','u','e','s','t','\0','s','t','o','r',
            'a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B',
            'S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k',
            's','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','I','s','U','s','e',
            'r','P','e','r','m','i','t','t','e','d','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s',
            'a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0','s',
            't','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e',
            'r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T',
            'a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','I','n','t','3','2',']',' ','A','d','d','E',
            'm','p','t','y','U','s','e','r','A','s','y','n','c','(',')',':','R','e','q','u','e','s','t','\0','s','t','o','r','a','g',
            'e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e',
            'r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.',
            'T','a','s','k','`','1','[','S','y','s','t','e','m','.','I','n','t','3','2',']',' ','A','d','d','E','m','p','t','y','U',
            's','e','r','A','s','y','n','c','(',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e','U','n','i',
            'v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r','v','S','o',
            'a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k',
            '`','1','[','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v',
            '.','U','s','e','r',']',' ','G','e','t','F','u','l','l','U','s','e','r','A','s','y','n','c','(','s','t','o','r','a','g',
            'e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e',
            'q','u','e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S',
            'e','r','v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e',
            'a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','s','t','o','r','a','g','e','U','n','i','v',
            'e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',']',' ','G','e','t','F','u','l','l',
            'U','s','e','r','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e',
            'r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e',
            'U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r',
            'v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T',
            'a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','u','p','d','a','t','e','U','s',
            'e','r','B','y','I','d','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U',
            's','e','r','D','B','S','e','r','v','.','U','s','e','r',',',' ','s','t','o','r','a','g','e','U','n','i','v','e','r','s',
            'a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',',',' ','I','n','t','3','2',')',':','R','e','q',
            'u','e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e',
            'r','v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a',
            'd','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e',
            'a','n',']',' ','u','p','d','a','t','e','U','s','e','r','B','y','I','d','A','s','y','n','c','(','s','t','o','r','a','g',
            'e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',',',' ','s','t',
            'o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',
            ',',' ','I','n','t','3','2',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e','U','n','i','v','e',
            'r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',
            ':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1',
            '[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','u','p','d','a','t','e','U','s','e','r','B','y','I',
            'd','A','d','m','i','n','A','s','y','n','c','(','I','n','t','3','2',',',' ','s','t','o','r','a','g','e','U','n','i','v',
            'e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',',',' ','s','t','o','r','a','g','e',
            'U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','q',
            'u','e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e',
            'r','v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a',
            'd','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e',
            'a','n',']',' ','u','p','d','a','t','e','U','s','e','r','B','y','I','d','A','d','m','i','n','A','s','y','n','c','(','I',
            'n','t','3','2',',',' ','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S',
            'e','r','v','.','U','s','e','r',',',' ','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e',
            'r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e',
            'U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r',
            'v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T',
            'a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','u','p','d','a','t','e','U','s',
            'e','r','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D',
            'B','S','e','r','v','.','U','s','e','r',',',' ','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U',
            's','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','q','u','e','s','t','\0','s','t','o','r','a','g',
            'e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e',
            'r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.',
            'T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','u','p','d','a','t','e','U',
            's','e','r','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r',
            'D','B','S','e','r','v','.','U','s','e','r',',',' ','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.',
            'U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r',
            'a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B',
            'S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k',
            's','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','D','e','l','e','t',
            'e','U','s','e','r','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s',
            'e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','q','u','e','s','t','\0','s','t','o','r','a','g','e',
            'U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r',
            'v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T',
            'a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','D','e','l','e','t','e','U','s',
            'e','r','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D',
            'B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e','U','n',
            'i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r','v','S',
            'o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s',
            'k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','D','e','l','e','t','e','U','s','e','r',
            'A','d','m','i','n','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s',
            'e','r','D','B','S','e','r','v','.','U','s','e','r',',',' ','I','n','t','3','2',')',':','R','e','q','u','e','s','t','\0',
            's','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s',
            'e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.',
            'T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','D',
            'e','l','e','t','e','U','s','e','r','A','d','m','i','n','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i',
            'v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',',',' ','I','n','t','3','2',')',
            ':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e',
            'r','D','B','S','e','r','v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.',
            'T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.',
            'B','o','o','l','e','a','n',']',' ','I','s','A','d','m','i','n','A','s','y','n','c','(','s','t','o','r','a','g','e','U',
            'n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','q','u',
            'e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r',
            'v','.','U','s','e','r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d',
            'i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a',
            'n',']',' ','I','s','A','d','m','i','n','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s',
            'a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0','s',
            't','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e',
            'r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T',
            'a','s','k','s','.','T','a','s','k','`','1','[','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U',
            's','e','r','D','B','S','e','r','v','.','G','e','t','A','d','m','i','n','U','s','e','r','T','b','l','R','e','s','p','o',
            'n','s','e','G','e','t','A','d','m','i','n','U','s','e','r','T','b','l','R','e','s','u','l','t',']',' ','G','e','t','A',
            'd','m','i','n','U','s','e','r','T','b','l','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r',
            's','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','q','u','e','s','t','\0','s',
            't','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e',
            'r','D','B','S','e','r','v','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T',
            'a','s','k','s','.','T','a','s','k','`','1','[','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','U',
            's','e','r','D','B','S','e','r','v','.','G','e','t','A','d','m','i','n','U','s','e','r','T','b','l','R','e','s','p','o',
            'n','s','e','G','e','t','A','d','m','i','n','U','s','e','r','T','b','l','R','e','s','u','l','t',']',' ','G','e','t','A',
            'd','m','i','n','U','s','e','r','T','b','l','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r',
            's','a','l','.','U','s','e','r','D','B','S','e','r','v','.','U','s','e','r',')',':','R','e','s','p','o','n','s','e','\0',
            's','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v',
            '.','I','n','v','e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r',
            'e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','S','t','r',
            'i','n','g',']',' ','H','e','l','l','o','W','o','r','l','d','A','s','y','n','c','(',')',':','R','e','q','u','e','s','t',
            '\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r',
            'v','.','I','n','v','e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',':','S','y','s','t','e','m','.','T','h',
            'r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','S','t',
            'r','i','n','g',']',' ','H','e','l','l','o','W','o','r','l','d','A','s','y','n','c','(',')',':','R','e','s','p','o','n',
            's','e','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S',
            'e','r','v','.','I','n','v','e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',':','S','y','s','t','e','m','.',
            'T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','s','t','o','r','a','g','e',
            'U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','G','e','t','I','n','v',
            'e','n','t','o','r','y','D','a','t','a','T','a','b','l','e','R','e','s','p','o','n','s','e','G','e','t','I','n','v','e',
            'n','t','o','r','y','D','a','t','a','T','a','b','l','e','R','e','s','u','l','t',']',' ','G','e','t','I','n','v','e','n',
            't','o','r','y','D','a','t','a','T','a','b','l','e','A','s','y','n','c','(',')',':','R','e','q','u','e','s','t','\0','s',
            't','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.',
            'I','n','v','e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e',
            'a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','s','t','o','r','a','g','e','U','n','i','v',
            'e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','G','e','t','I','n','v','e','n','t','o',
            'r','y','D','a','t','a','T','a','b','l','e','R','e','s','p','o','n','s','e','G','e','t','I','n','v','e','n','t','o','r',
            'y','D','a','t','a','T','a','b','l','e','R','e','s','u','l','t',']',' ','G','e','t','I','n','v','e','n','t','o','r','y',
            'D','a','t','a','T','a','b','l','e','A','s','y','n','c','(',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r',
            'a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','I','n','v',
            'e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i',
            'n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','s','t','o','r','a','g','e','U','n','i','v','e','r','s',
            'a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','G','e','t','I','n','v','e','n','t','o','r','y','U',
            's','e','r','D','a','t','a','T','a','b','l','e','R','e','s','p','o','n','s','e','G','e','t','I','n','v','e','n','t','o',
            'r','y','U','s','e','r','D','a','t','a','T','a','b','l','e','R','e','s','u','l','t',']',' ','G','e','t','I','n','v','e',
            'n','t','o','r','y','U','s','e','r','D','a','t','a','T','a','b','l','e','A','s','y','n','c','(','I','n','t','3','2',')',
            ':','R','e','q','u','e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e',
            'n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',':','S',
            'y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','s',
            't','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.',
            'G','e','t','I','n','v','e','n','t','o','r','y','U','s','e','r','D','a','t','a','T','a','b','l','e','R','e','s','p','o',
            'n','s','e','G','e','t','I','n','v','e','n','t','o','r','y','U','s','e','r','D','a','t','a','T','a','b','l','e','R','e',
            's','u','l','t',']',' ','G','e','t','I','n','v','e','n','t','o','r','y','U','s','e','r','D','a','t','a','T','a','b','l',
            'e','A','s','y','n','c','(','I','n','t','3','2',')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e',
            'U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t',
            'o','r','y','F','u','n','c','s','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.',
            'T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','c',
            'h','a','n','g','e','I','n','v','e','n','t','o','r','y','R','o','w','A','s','y','n','c','(','s','t','o','r','a','g','e',
            'U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t',
            'o','r','y','R','o','w',')',':','R','e','q','u','e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s',
            'a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t','o','r','y','F','u','n','c',
            's','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T',
            'a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','c','h','a','n','g','e','I','n',
            'v','e','n','t','o','r','y','R','o','w','A','s','y','n','c','(','s','t','o','r','a','g','e','U','n','i','v','e','r','s',
            'a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t','o','r','y','R','o','w',')',
            ':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n','v',
            'e','n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',':',
            'S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1','[',
            'S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',' ','D','e','l','e','t','e','I','n','v','e','n','t','o','r',
            'y','R','o','w','A','s','y','n','c','(','I','n','t','3','2',')',':','R','e','q','u','e','s','t','\0','s','t','o','r','a',
            'g','e','U','n','i','v','e','r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','I','n','v','e',
            'n','t','o','r','y','F','u','n','c','s','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n',
            'g','.','T','a','s','k','s','.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','B','o','o','l','e','a','n',']',
            ' ','D','e','l','e','t','e','I','n','v','e','n','t','o','r','y','R','o','w','A','s','y','n','c','(','I','n','t','3','2',
            ')',':','R','e','s','p','o','n','s','e','\0','s','t','o','r','a','g','e','U','n','i','v','e','r','s','a','l','.','I','n',
            'v','e','n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t','o','r','y','F','u','n','c','s','S','o','a','p',
            ':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s','.','T','a','s','k','`','1',
            '[','S','y','s','t','e','m','.','I','n','t','3','2',']',' ','g','e','t','N','e','w','I','t','e','m','I','d','A','s','y',
            'n','c','(','I','n','t','3','2',')',':','R','e','q','u','e','s','t','\0','s','t','o','r','a','g','e','U','n','i','v','e',
            'r','s','a','l','.','I','n','v','e','n','t','o','r','y','S','e','r','v','.','I','n','v','e','n','t','o','r','y','F','u',
            'n','c','s','S','o','a','p',':','S','y','s','t','e','m','.','T','h','r','e','a','d','i','n','g','.','T','a','s','k','s',
            '.','T','a','s','k','`','1','[','S','y','s','t','e','m','.','I','n','t','3','2',']',' ','g','e','t','N','e','w','I','t',
            'e','m','I','d','A','s','y','n','c','(','I','n','t','3','2',')',':','R','e','s','p','o','n','s','e','\0'};
    }
}
