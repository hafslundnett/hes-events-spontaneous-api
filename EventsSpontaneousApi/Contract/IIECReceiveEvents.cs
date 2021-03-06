﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://aidon.com/IEC/Event/v2/ReceiveEvents", ConfigurationName="IIECReceiveEvents")]
public interface IIECReceiveEvents
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://aidon.com/IEC/Event/v2/ReceiveEvents/IECEventReceiveEventsPortType/Created" +
        "ConfigurationEventRequest", ReplyAction="http://aidon.com/IEC/Event/v2/ReceiveEvents/IECEventReceiveEventsPortType/Created" +
        "ConfigurationEventResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadTypeBase))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EventRequestMessageTypeBase1))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EventRequestMessageTypeBase))]
    System.Threading.Tasks.Task<CreatedConfigurationEventResponse> CreatedConfigurationEventAsync(CreatedConfigurationEventRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://aidon.com/IEC/Event/v2/ReceiveEvents/IECEventReceiveEventsPortType/Created" +
        "EndDeviceEventRequest", ReplyAction="http://aidon.com/IEC/Event/v2/ReceiveEvents/IECEventReceiveEventsPortType/Created" +
        "EndDeviceEventResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadTypeBase))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EventRequestMessageTypeBase1))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EventRequestMessageTypeBase))]
    System.Threading.Tasks.Task<CreatedEndDeviceEventResponse> CreatedEndDeviceEventAsync(CreatedEndDeviceEventRequest request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/ConfigurationEventMessage")]
public partial class CreatedConfigurationEventRequestMessageType : EventRequestMessageTypeBase
{
    
    private ConfigurationEventPayloadType payloadField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ConfigurationEventPayloadType Payload
    {
        get
        {
            return this.payloadField;
        }
        set
        {
            this.payloadField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/ConfigurationEventMessage")]
public partial class ConfigurationEventPayloadType
{
    
    private ConfigurationEvent[] configurationEventsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://iec.ch/TC57/2007/ConfigurationEvent#", Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public ConfigurationEvent[] ConfigurationEvents
    {
        get
        {
            return this.configurationEventsField;
        }
        set
        {
            this.configurationEventsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2007/ConfigurationEvent#")]
public partial class ConfigurationEvent
{
    
    private System.DateTime effectiveDateTimeField;
    
    private string modifiedByField;
    
    private identifiedObject changedEntityField;
    
    private int sequenceNumberField;
    
    private bool sequenceNumberFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public System.DateTime effectiveDateTime
    {
        get
        {
            return this.effectiveDateTimeField;
        }
        set
        {
            this.effectiveDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string modifiedBy
    {
        get
        {
            return this.modifiedByField;
        }
        set
        {
            this.modifiedByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public identifiedObject changedEntity
    {
        get
        {
            return this.changedEntityField;
        }
        set
        {
            this.changedEntityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int SequenceNumber
    {
        get
        {
            return this.sequenceNumberField;
        }
        set
        {
            this.sequenceNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SequenceNumberSpecified
    {
        get
        {
            return this.sequenceNumberFieldSpecified;
        }
        set
        {
            this.sequenceNumberFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/Common")]
public partial class identifiedObject
{
    
    private string mRIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string mRID
    {
        get
        {
            return this.mRIDField;
        }
        set
        {
            this.mRIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/EndDeviceEventMessage")]
public partial class CreatedEndDeviceEventResponseMessageType
{
    
    private HeaderType headerField;
    
    private ReplyType replyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public HeaderType Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ReplyType Reply
    {
        get
        {
            return this.replyField;
        }
        set
        {
            this.replyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2011/schema/message")]
public partial class HeaderType
{
    
    private HeaderTypeVerb verbField;
    
    private string nounField;
    
    private System.Nullable<System.DateTime> timestampField;
    
    private string sourceField;
    
    private string replyAddressField;
    
    private string messageIDField;
    
    private string correlationIDField;
    
    private string accessTokenField;
    
    private string organisationIDField;
    
    private bool useGuaranteedDeliveryField;
    
    private bool useGuaranteedDeliveryFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public HeaderTypeVerb Verb
    {
        get
        {
            return this.verbField;
        }
        set
        {
            this.verbField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
    public string Noun
    {
        get
        {
            return this.nounField;
        }
        set
        {
            this.nounField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
    public System.Nullable<System.DateTime> Timestamp
    {
        get
        {
            return this.timestampField;
        }
        set
        {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
    public string Source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string ReplyAddress
    {
        get
        {
            return this.replyAddressField;
        }
        set
        {
            this.replyAddressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
    public string MessageID
    {
        get
        {
            return this.messageIDField;
        }
        set
        {
            this.messageIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
    public string CorrelationID
    {
        get
        {
            return this.correlationIDField;
        }
        set
        {
            this.correlationIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string AccessToken
    {
        get
        {
            return this.accessTokenField;
        }
        set
        {
            this.accessTokenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string OrganisationID
    {
        get
        {
            return this.organisationIDField;
        }
        set
        {
            this.organisationIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public bool UseGuaranteedDelivery
    {
        get
        {
            return this.useGuaranteedDeliveryField;
        }
        set
        {
            this.useGuaranteedDeliveryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool UseGuaranteedDeliverySpecified
    {
        get
        {
            return this.useGuaranteedDeliveryFieldSpecified;
        }
        set
        {
            this.useGuaranteedDeliveryFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://iec.ch/TC57/2011/schema/message")]
public enum HeaderTypeVerb
{
    
    /// <remarks/>
    cancel,
    
    /// <remarks/>
    canceled,
    
    /// <remarks/>
    change,
    
    /// <remarks/>
    changed,
    
    /// <remarks/>
    create,
    
    /// <remarks/>
    created,
    
    /// <remarks/>
    close,
    
    /// <remarks/>
    closed,
    
    /// <remarks/>
    delete,
    
    /// <remarks/>
    deleted,
    
    /// <remarks/>
    get,
    
    /// <remarks/>
    reply,
    
    /// <remarks/>
    execute,
    
    /// <remarks/>
    executed,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2011/schema/message")]
public partial class ReplyType
{
    
    private ReplyTypeResult resultField;
    
    private ErrorType[] errorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ReplyTypeResult Result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error", Order=1)]
    public ErrorType[] Error
    {
        get
        {
            return this.errorField;
        }
        set
        {
            this.errorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://iec.ch/TC57/2011/schema/message")]
public enum ReplyTypeResult
{
    
    /// <remarks/>
    OK,
    
    /// <remarks/>
    PARTIAL,
    
    /// <remarks/>
    FAILED,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2011/schema/message")]
public partial class ErrorType
{
    
    private string codeField;
    
    private ErrorTypeLevel levelField;
    
    private string reasonField;
    
    private string detailsField;
    
    private string stackTraceField;
    
    private ErrorTypeID idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ErrorTypeLevel level
    {
        get
        {
            return this.levelField;
        }
        set
        {
            this.levelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string reason
    {
        get
        {
            return this.reasonField;
        }
        set
        {
            this.reasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string details
    {
        get
        {
            return this.detailsField;
        }
        set
        {
            this.detailsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string stackTrace
    {
        get
        {
            return this.stackTraceField;
        }
        set
        {
            this.stackTraceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public ErrorTypeID ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://iec.ch/TC57/2011/schema/message")]
public enum ErrorTypeLevel
{
    
    /// <remarks/>
    INFORM,
    
    /// <remarks/>
    WARNING,
    
    /// <remarks/>
    FATAL,
    
    /// <remarks/>
    CATASTROPHIC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://iec.ch/TC57/2011/schema/message")]
public partial class ErrorTypeID
{
    
    private string objectTypeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectType
    {
        get
        {
            return this.objectTypeField;
        }
        set
        {
            this.objectTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2007/EndDeviceEvent#")]
public partial class Reading
{
    
    private string valueField;
    
    private ReadingReadingType readingTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ReadingReadingType ReadingType
    {
        get
        {
            return this.readingTypeField;
        }
        set
        {
            this.readingTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://iec.ch/TC57/2007/EndDeviceEvent#")]
public partial class ReadingReadingType
{
    
    private string refField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @ref
    {
        get
        {
            return this.refField;
        }
        set
        {
            this.refField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2007/EndDeviceEvent#")]
public partial class MeterReading
{
    
    private Reading[] readingsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Reading[] Readings
    {
        get
        {
            return this.readingsField;
        }
        set
        {
            this.readingsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2007/EndDeviceEvent#")]
public partial class EndDeviceEventType
{
    
    private string typeField;
    
    private string domainField;
    
    private string subDomainField;
    
    private string eventOrActionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string domain
    {
        get
        {
            return this.domainField;
        }
        set
        {
            this.domainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string subDomain
    {
        get
        {
            return this.subDomainField;
        }
        set
        {
            this.subDomainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string eventOrAction
    {
        get
        {
            return this.eventOrActionField;
        }
        set
        {
            this.eventOrActionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2007/EndDeviceEvent#")]
public partial class EndDeviceEventDetail
{
    
    private string nameField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iec.ch/TC57/2007/EndDeviceEvent#")]
public partial class EndDeviceEvent
{
    
    private System.DateTime createdDateTimeField;
    
    private EndDeviceEventDetail[] endDeviceEventDetailsField;
    
    private EndDeviceEventType endDeviceEventTypeField;
    
    private MeterReading meterReadingField;
    
    private identifiedObject usagePointField;
    
    private identifiedObject endDeviceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public System.DateTime createdDateTime
    {
        get
        {
            return this.createdDateTimeField;
        }
        set
        {
            this.createdDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public EndDeviceEventDetail[] EndDeviceEventDetails
    {
        get
        {
            return this.endDeviceEventDetailsField;
        }
        set
        {
            this.endDeviceEventDetailsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EndDeviceEventType EndDeviceEventType
    {
        get
        {
            return this.endDeviceEventTypeField;
        }
        set
        {
            this.endDeviceEventTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public MeterReading MeterReading
    {
        get
        {
            return this.meterReadingField;
        }
        set
        {
            this.meterReadingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public identifiedObject UsagePoint
    {
        get
        {
            return this.usagePointField;
        }
        set
        {
            this.usagePointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public identifiedObject EndDevice
    {
        get
        {
            return this.endDeviceField;
        }
        set
        {
            this.endDeviceField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EndDeviceEventPayloadType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/EndDeviceEventMessage")]
public abstract partial class PayloadTypeBase
{
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/EndDeviceEventMessage")]
public partial class EndDeviceEventPayloadType : PayloadTypeBase
{
    
    private EndDeviceEvent[] endDeviceEventsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://iec.ch/TC57/2007/EndDeviceEvent#", IsNullable=false)]
    public EndDeviceEvent[] EndDeviceEvents
    {
        get
        {
            return this.endDeviceEventsField;
        }
        set
        {
            this.endDeviceEventsField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CreatedEndDeviceEventRequestMessageType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="EventRequestMessageTypeBase", Namespace="http://aidon.com/IEC/Event/v2/EndDeviceEventMessage")]
public abstract partial class EventRequestMessageTypeBase1
{
    
    private HeaderType headerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public HeaderType Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/EndDeviceEventMessage")]
public partial class CreatedEndDeviceEventRequestMessageType : EventRequestMessageTypeBase1
{
    
    private EndDeviceEventPayloadType payloadField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public EndDeviceEventPayloadType Payload
    {
        get
        {
            return this.payloadField;
        }
        set
        {
            this.payloadField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/ConfigurationEventMessage")]
public partial class CreatedConfigurationEventResponseMessageType
{
    
    private HeaderType headerField;
    
    private ReplyType replyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public HeaderType Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ReplyType Reply
    {
        get
        {
            return this.replyField;
        }
        set
        {
            this.replyField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CreatedConfigurationEventRequestMessageType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aidon.com/IEC/Event/v2/ConfigurationEventMessage")]
public abstract partial class EventRequestMessageTypeBase
{
    
    private HeaderType headerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public HeaderType Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class CreatedConfigurationEventRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="CreatedConfigurationEventRequest", Namespace="http://aidon.com/IEC/Event/v2/ConfigurationEventMessage", Order=0)]
    public CreatedConfigurationEventRequestMessageType CreatedConfigurationEventRequest1;
    
    public CreatedConfigurationEventRequest()
    {
    }
    
    public CreatedConfigurationEventRequest(CreatedConfigurationEventRequestMessageType CreatedConfigurationEventRequest1)
    {
        this.CreatedConfigurationEventRequest1 = CreatedConfigurationEventRequest1;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class CreatedConfigurationEventResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="CreatedConfigurationEventResponse", Namespace="http://aidon.com/IEC/Event/v2/ConfigurationEventMessage", Order=0)]
    public CreatedConfigurationEventResponseMessageType CreatedConfigurationEventResponse1;
    
    public CreatedConfigurationEventResponse()
    {
    }
    
    public CreatedConfigurationEventResponse(CreatedConfigurationEventResponseMessageType CreatedConfigurationEventResponse1)
    {
        this.CreatedConfigurationEventResponse1 = CreatedConfigurationEventResponse1;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class CreatedEndDeviceEventRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="CreatedEndDeviceEventRequest", Namespace="http://aidon.com/IEC/Event/v2/EndDeviceEventMessage", Order=0)]
    public CreatedEndDeviceEventRequestMessageType CreatedEndDeviceEventRequest1;
    
    public CreatedEndDeviceEventRequest()
    {
    }
    
    public CreatedEndDeviceEventRequest(CreatedEndDeviceEventRequestMessageType CreatedEndDeviceEventRequest1)
    {
        this.CreatedEndDeviceEventRequest1 = CreatedEndDeviceEventRequest1;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class CreatedEndDeviceEventResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="CreatedEndDeviceEventResponse", Namespace="http://aidon.com/IEC/Event/v2/EndDeviceEventMessage", Order=0)]
    public CreatedEndDeviceEventResponseMessageType CreatedEndDeviceEventResponse1;
    
    public CreatedEndDeviceEventResponse()
    {
    }
    
    public CreatedEndDeviceEventResponse(CreatedEndDeviceEventResponseMessageType CreatedEndDeviceEventResponse1)
    {
        this.CreatedEndDeviceEventResponse1 = CreatedEndDeviceEventResponse1;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
public interface IIECReceiveEventsChannel : IIECReceiveEvents, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
public partial class IECReceiveEventsClient : System.ServiceModel.ClientBase<IIECReceiveEvents>, IIECReceiveEvents
{
    
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
    
    public IECReceiveEventsClient() : 
            base(IECReceiveEventsClient.GetDefaultBinding(), IECReceiveEventsClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.IECReceiveEvents.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public IECReceiveEventsClient(EndpointConfiguration endpointConfiguration) : 
            base(IECReceiveEventsClient.GetBindingForEndpoint(endpointConfiguration), IECReceiveEventsClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public IECReceiveEventsClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
            base(IECReceiveEventsClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public IECReceiveEventsClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(IECReceiveEventsClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public IECReceiveEventsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<CreatedConfigurationEventResponse> IIECReceiveEvents.CreatedConfigurationEventAsync(CreatedConfigurationEventRequest request)
    {
        return base.Channel.CreatedConfigurationEventAsync(request);
    }
    
    public System.Threading.Tasks.Task<CreatedConfigurationEventResponse> CreatedConfigurationEventAsync(CreatedConfigurationEventRequestMessageType CreatedConfigurationEventRequest1)
    {
        CreatedConfigurationEventRequest inValue = new CreatedConfigurationEventRequest();
        inValue.CreatedConfigurationEventRequest1 = CreatedConfigurationEventRequest1;
        return ((IIECReceiveEvents)(this)).CreatedConfigurationEventAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<CreatedEndDeviceEventResponse> IIECReceiveEvents.CreatedEndDeviceEventAsync(CreatedEndDeviceEventRequest request)
    {
        return base.Channel.CreatedEndDeviceEventAsync(request);
    }
    
    public System.Threading.Tasks.Task<CreatedEndDeviceEventResponse> CreatedEndDeviceEventAsync(CreatedEndDeviceEventRequestMessageType CreatedEndDeviceEventRequest1)
    {
        CreatedEndDeviceEventRequest inValue = new CreatedEndDeviceEventRequest();
        inValue.CreatedEndDeviceEventRequest1 = CreatedEndDeviceEventRequest1;
        return ((IIECReceiveEvents)(this)).CreatedEndDeviceEventAsync(inValue);
    }
    
    public virtual System.Threading.Tasks.Task OpenAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
    }
    
    public virtual System.Threading.Tasks.Task CloseAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
    }
    
    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.IECReceiveEvents))
        {
            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
            result.MaxBufferSize = int.MaxValue;
            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            result.MaxReceivedMessageSize = int.MaxValue;
            result.AllowCookies = true;
            return result;
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.IECReceiveEvents))
        {
            return new System.ServiceModel.EndpointAddress("http://localhost:44505/IECEventTestingSubscriber.svc");
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return IECReceiveEventsClient.GetBindingForEndpoint(EndpointConfiguration.IECReceiveEvents);
    }
    
    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return IECReceiveEventsClient.GetEndpointAddress(EndpointConfiguration.IECReceiveEvents);
    }
    
    public enum EndpointConfiguration
    {
        
        IECReceiveEvents,
    }
}
