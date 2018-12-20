﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace OneNoteExporter
{
    public class oneNoteModels
    {
        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        [XmlRoot(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
        public partial class Notebooks
        {

            private Notebook[] notebookField;

            private UnfiledNotes unfiledNotesField;

            private OpenSections openSectionsField;

            /// <remarks/>
            [XmlElement("Notebook")]
            public Notebook[] Notebook
            {
                get
                {
                    return this.notebookField;
                }
                set
                {
                    this.notebookField = value;
                }
            }

            /// <remarks/>
            public UnfiledNotes UnfiledNotes
            {
                get
                {
                    return this.unfiledNotesField;
                }
                set
                {
                    this.unfiledNotesField = value;
                }
            }

            /// <remarks/>
            public OpenSections OpenSections
            {
                get
                {
                    return this.openSectionsField;
                }
                set
                {
                    this.openSectionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        [XmlRoot(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
        public partial class Notebook
        {

            private Section[] sectionField;

            private SectionGroup[] sectionGroupField;

            private string nicknameField;

            private string colorField;

            private bool isUnreadField;

            private bool isUnreadFieldSpecified;

            private string idField;

            private string nameField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private bool isCurrentlyViewedField;

            private bool isInRecycleBinField;

            private string pathField;

            public Notebook()
            {
                this.colorField = "automatic";
                this.isCurrentlyViewedField = false;
                this.isInRecycleBinField = false;
            }

            /// <remarks/>
            [XmlElement("Section")]
            public Section[] Section
            {
                get
                {
                    return this.sectionField;
                }
                set
                {
                    this.sectionField = value;
                }
            }

            /// <remarks/>
            [XmlElement("SectionGroup")]
            public SectionGroup[] SectionGroup
            {
                get
                {
                    return this.sectionGroupField;
                }
                set
                {
                    this.sectionGroupField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string nickname
            {
                get
                {
                    return this.nicknameField;
                }
                set
                {
                    this.nicknameField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool isUnread
            {
                get
                {
                    return this.isUnreadField;
                }
                set
                {
                    this.isUnreadField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool isUnreadSpecified
            {
                get
                {
                    return this.isUnreadFieldSpecified;
                }
                set
                {
                    this.isUnreadFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string ID
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

            /// <remarks/>
            [XmlAttribute()]
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
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isCurrentlyViewed
            {
                get
                {
                    return this.isCurrentlyViewedField;
                }
                set
                {
                    this.isCurrentlyViewedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isInRecycleBin
            {
                get
                {
                    return this.isInRecycleBinField;
                }
                set
                {
                    this.isInRecycleBinField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string path
            {
                get
                {
                    return this.pathField;
                }
                set
                {
                    this.pathField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        [XmlRoot(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
        public partial class Section
        {

            private Page[] pageField;

            private string colorField;

            private bool encryptedField;

            private bool lockedField;

            private bool isUnreadField;

            private bool isUnreadFieldSpecified;

            private bool readOnlyField;

            private bool areAllPagesAvailableField;

            private bool isDeletedPagesField;

            private string idField;

            private string nameField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private bool isCurrentlyViewedField;

            private bool isInRecycleBinField;

            private string pathField;

            public Section()
            {
                this.colorField = "automatic";
                this.encryptedField = false;
                this.lockedField = false;
                this.readOnlyField = false;
                this.areAllPagesAvailableField = true;
                this.isDeletedPagesField = false;
                this.isCurrentlyViewedField = false;
                this.isInRecycleBinField = false;
            }

            /// <remarks/>
            [XmlElement("Page")]
            public Page[] Page
            {
                get
                {
                    return this.pageField;
                }
                set
                {
                    this.pageField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool encrypted
            {
                get
                {
                    return this.encryptedField;
                }
                set
                {
                    this.encryptedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool locked
            {
                get
                {
                    return this.lockedField;
                }
                set
                {
                    this.lockedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool isUnread
            {
                get
                {
                    return this.isUnreadField;
                }
                set
                {
                    this.isUnreadField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool isUnreadSpecified
            {
                get
                {
                    return this.isUnreadFieldSpecified;
                }
                set
                {
                    this.isUnreadFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool readOnly
            {
                get
                {
                    return this.readOnlyField;
                }
                set
                {
                    this.readOnlyField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool areAllPagesAvailable
            {
                get
                {
                    return this.areAllPagesAvailableField;
                }
                set
                {
                    this.areAllPagesAvailableField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isDeletedPages
            {
                get
                {
                    return this.isDeletedPagesField;
                }
                set
                {
                    this.isDeletedPagesField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string ID
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

            /// <remarks/>
            [XmlAttribute()]
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
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isCurrentlyViewed
            {
                get
                {
                    return this.isCurrentlyViewedField;
                }
                set
                {
                    this.isCurrentlyViewedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isInRecycleBin
            {
                get
                {
                    return this.isInRecycleBinField;
                }
                set
                {
                    this.isInRecycleBinField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string path
            {
                get
                {
                    return this.pathField;
                }
                set
                {
                    this.pathField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        [XmlRoot(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
        public partial class Page
        {

            private TagDef[] tagDefField;

            private QuickStyleDef[] quickStyleDefField;

            private XPSFile[] xPSFileField;

            private Meta[] metaField;

            private MediaReference[] mediaPlaylistField;

            private MeetingInfo meetingInfoField;

            private PageSettings pageSettingsField;

            private Title titleField;

            private PageObject[] itemsField;

            private System.DateTime dateTimeField;

            private bool dateTimeFieldSpecified;

            private string selectedField;

            private bool isSubPageField;

            private bool isSubPageFieldSpecified;

            private string pageLevelField;

            private bool isCollapsedField;

            private bool isUnreadField;

            private bool isUnreadFieldSpecified;

            private bool isIndexedField;

            private bool hasFutureContentField;

            private string stationeryNameField;

            private string idField;

            private string nameField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private bool isCurrentlyViewedField;

            private bool isInRecycleBinField;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            public Page()
            {
                this.selectedField = "none";
                this.isCollapsedField = false;
                this.isIndexedField = true;
                this.hasFutureContentField = false;
                this.isCurrentlyViewedField = false;
                this.isInRecycleBinField = false;
            }

            /// <remarks/>
            [XmlElement("TagDef")]
            public TagDef[] TagDef
            {
                get
                {
                    return this.tagDefField;
                }
                set
                {
                    this.tagDefField = value;
                }
            }

            /// <remarks/>
            [XmlElement("QuickStyleDef")]
            public QuickStyleDef[] QuickStyleDef
            {
                get
                {
                    return this.quickStyleDefField;
                }
                set
                {
                    this.quickStyleDefField = value;
                }
            }

            /// <remarks/>
            [XmlElement("XPSFile")]
            public XPSFile[] XPSFile
            {
                get
                {
                    return this.xPSFileField;
                }
                set
                {
                    this.xPSFileField = value;
                }
            }

            /// <remarks/>
            [XmlElement("Meta")]
            public Meta[] Meta
            {
                get
                {
                    return this.metaField;
                }
                set
                {
                    this.metaField = value;
                }
            }

            /// <remarks/>
            [XmlArrayItem(IsNullable = false)]
            public MediaReference[] MediaPlaylist
            {
                get
                {
                    return this.mediaPlaylistField;
                }
                set
                {
                    this.mediaPlaylistField = value;
                }
            }

            /// <remarks/>
            public MeetingInfo MeetingInfo
            {
                get
                {
                    return this.meetingInfoField;
                }
                set
                {
                    this.meetingInfoField = value;
                }
            }

            /// <remarks/>
            public PageSettings PageSettings
            {
                get
                {
                    return this.pageSettingsField;
                }
                set
                {
                    this.pageSettingsField = value;
                }
            }

            /// <remarks/>
            public Title Title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [XmlElement("FutureObject", typeof(FutureObject))]
            [XmlElement("Image", typeof(Image))]
            [XmlElement("InkDrawing", typeof(InkDrawing))]
            [XmlElement("InsertedFile", typeof(InsertedFile))]
            [XmlElement("MediaFile", typeof(MediaFile))]
            [XmlElement("Outline", typeof(Outline))]
            public PageObject[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime dateTime
            {
                get
                {
                    return this.dateTimeField;
                }
                set
                {
                    this.dateTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool dateTimeSpecified
            {
                get
                {
                    return this.dateTimeFieldSpecified;
                }
                set
                {
                    this.dateTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool isSubPage
            {
                get
                {
                    return this.isSubPageField;
                }
                set
                {
                    this.isSubPageField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool isSubPageSpecified
            {
                get
                {
                    return this.isSubPageFieldSpecified;
                }
                set
                {
                    this.isSubPageFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "integer")]
            public string pageLevel
            {
                get
                {
                    return this.pageLevelField;
                }
                set
                {
                    this.pageLevelField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isCollapsed
            {
                get
                {
                    return this.isCollapsedField;
                }
                set
                {
                    this.isCollapsedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool isUnread
            {
                get
                {
                    return this.isUnreadField;
                }
                set
                {
                    this.isUnreadField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool isUnreadSpecified
            {
                get
                {
                    return this.isUnreadFieldSpecified;
                }
                set
                {
                    this.isUnreadFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool isIndexed
            {
                get
                {
                    return this.isIndexedField;
                }
                set
                {
                    this.isIndexedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool hasFutureContent
            {
                get
                {
                    return this.hasFutureContentField;
                }
                set
                {
                    this.hasFutureContentField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string stationeryName
            {
                get
                {
                    return this.stationeryNameField;
                }
                set
                {
                    this.stationeryNameField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string ID
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

            /// <remarks/>
            [XmlAttribute()]
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
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isCurrentlyViewed
            {
                get
                {
                    return this.isCurrentlyViewedField;
                }
                set
                {
                    this.isCurrentlyViewedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isInRecycleBin
            {
                get
                {
                    return this.isInRecycleBinField;
                }
                set
                {
                    this.isInRecycleBinField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class TagDef
        {

            private string indexField;

            private string nameField;

            private string typeField;

            private string symbolField;

            private string fontColorField;

            private string highlightColorField;

            public TagDef()
            {
                this.fontColorField = "automatic";
                this.highlightColorField = "none";
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string index
            {
                get
                {
                    return this.indexField;
                }
                set
                {
                    this.indexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
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
            [XmlAttribute(DataType = "nonNegativeInteger")]
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
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string fontColor
            {
                get
                {
                    return this.fontColorField;
                }
                set
                {
                    this.fontColorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string highlightColor
            {
                get
                {
                    return this.highlightColorField;
                }
                set
                {
                    this.highlightColorField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class LinkedNoteThumbnail
        {

            private object itemField;

            /// <remarks/>
            [XmlElement("CallbackID", typeof(CallbackID))]
            [XmlElement("Data", typeof(byte[]), DataType = "base64Binary")]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class CallbackID
        {

            private string callbackIDField;

            /// <remarks/>
            [XmlAttribute()]
            public string callbackID
            {
                get
                {
                    return this.callbackIDField;
                }
                set
                {
                    this.callbackIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class LinkedNote
        {

            private string linkedNoteUriField;

            private string linkedNoteShortNameField;

            private string linkedNoteFriendlyNameField;

            private string linkedNoteDescriptionField;

            private LinkedNoteThumbnail linkedNoteThumbnailField;

            private string stateField;

            /// <remarks/>
            public string LinkedNoteUri
            {
                get
                {
                    return this.linkedNoteUriField;
                }
                set
                {
                    this.linkedNoteUriField = value;
                }
            }

            /// <remarks/>
            public string LinkedNoteShortName
            {
                get
                {
                    return this.linkedNoteShortNameField;
                }
                set
                {
                    this.linkedNoteShortNameField = value;
                }
            }

            /// <remarks/>
            public string LinkedNoteFriendlyName
            {
                get
                {
                    return this.linkedNoteFriendlyNameField;
                }
                set
                {
                    this.linkedNoteFriendlyNameField = value;
                }
            }

            /// <remarks/>
            public string LinkedNoteDescription
            {
                get
                {
                    return this.linkedNoteDescriptionField;
                }
                set
                {
                    this.linkedNoteDescriptionField = value;
                }
            }

            /// <remarks/>
            public LinkedNoteThumbnail LinkedNoteThumbnail
            {
                get
                {
                    return this.linkedNoteThumbnailField;
                }
                set
                {
                    this.linkedNoteThumbnailField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "integer")]
            public string state
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class TextRange
        {

            private string selectedField;

            private bool preserveWhiteSpaceField;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            private string valueField;

            public TextRange()
            {
                this.selectedField = "none";
                this.preserveWhiteSpaceField = true;
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool preserveWhiteSpace
            {
                get
                {
                    return this.preserveWhiteSpaceField;
                }
                set
                {
                    this.preserveWhiteSpaceField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }

            /// <remarks/>
            [XmlText()]
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class EndOfLine
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Space
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class InkWord
        {

            private object itemField;

            private string recognizedTextField;

            private string selectedField;

            private double xField;

            private bool xFieldSpecified;

            private double yField;

            private bool yFieldSpecified;

            private double widthField;

            private bool widthFieldSpecified;

            private double heightField;

            private bool heightFieldSpecified;

            private string styleField;

            private double inkOriginXField;

            private double inkOriginYField;

            public InkWord()
            {
                this.selectedField = "none";
                this.inkOriginXField = 0D;
                this.inkOriginYField = 0D;
            }

            /// <remarks/>
            [XmlElement("CallbackID", typeof(CallbackID))]
            [XmlElement("Data", typeof(byte[]), DataType = "base64Binary")]
            [XmlElement("EndOfLine", typeof(EndOfLine))]
            [XmlElement("File", typeof(FilePath))]
            [XmlElement("Space", typeof(Space))]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string recognizedText
            {
                get
                {
                    return this.recognizedTextField;
                }
                set
                {
                    this.recognizedTextField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double x
            {
                get
                {
                    return this.xField;
                }
                set
                {
                    this.xField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool xSpecified
            {
                get
                {
                    return this.xFieldSpecified;
                }
                set
                {
                    this.xFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool ySpecified
            {
                get
                {
                    return this.yFieldSpecified;
                }
                set
                {
                    this.yFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool widthSpecified
            {
                get
                {
                    return this.widthFieldSpecified;
                }
                set
                {
                    this.widthFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool heightSpecified
            {
                get
                {
                    return this.heightFieldSpecified;
                }
                set
                {
                    this.heightFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(0D)]
            public double inkOriginX
            {
                get
                {
                    return this.inkOriginXField;
                }
                set
                {
                    this.inkOriginXField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(0D)]
            public double inkOriginY
            {
                get
                {
                    return this.inkOriginYField;
                }
                set
                {
                    this.inkOriginYField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class FilePath
        {

            private string pathField;

            /// <remarks/>
            [XmlAttribute()]
            public string path
            {
                get
                {
                    return this.pathField;
                }
                set
                {
                    this.pathField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class InkParagraph
        {

            private InkWord[] inkWordField;

            private double xField;

            private bool xFieldSpecified;

            private double yField;

            private bool yFieldSpecified;

            private double widthField;

            private bool widthFieldSpecified;

            private double heightField;

            private bool heightFieldSpecified;

            /// <remarks/>
            [XmlElement("InkWord")]
            public InkWord[] InkWord
            {
                get
                {
                    return this.inkWordField;
                }
                set
                {
                    this.inkWordField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double x
            {
                get
                {
                    return this.xField;
                }
                set
                {
                    this.xField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool xSpecified
            {
                get
                {
                    return this.xFieldSpecified;
                }
                set
                {
                    this.xFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool ySpecified
            {
                get
                {
                    return this.yFieldSpecified;
                }
                set
                {
                    this.yFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool widthSpecified
            {
                get
                {
                    return this.widthFieldSpecified;
                }
                set
                {
                    this.widthFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool heightSpecified
            {
                get
                {
                    return this.heightFieldSpecified;
                }
                set
                {
                    this.heightFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Cell
        {

            private OEChildren[] oEChildrenField;

            private string objectIDField;

            private string selectedField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private string shadingColorField;

            private string meetingContentTypeField;

            private string authorField;

            private string authorInitialsField;

            private string authorResolutionIDField;

            private string lastModifiedByField;

            private string lastModifiedByInitialsField;

            private string lastModifiedByResolutionIDField;

            private System.DateTime creationTimeField;

            private bool creationTimeFieldSpecified;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            public Cell()
            {
                this.selectedField = "none";
            }

            /// <remarks/>
            [XmlElement("OEChildren")]
            public OEChildren[] OEChildren
            {
                get
                {
                    return this.oEChildrenField;
                }
                set
                {
                    this.oEChildrenField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string objectID
            {
                get
                {
                    return this.objectIDField;
                }
                set
                {
                    this.objectIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string shadingColor
            {
                get
                {
                    return this.shadingColorField;
                }
                set
                {
                    this.shadingColorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string meetingContentType
            {
                get
                {
                    return this.meetingContentTypeField;
                }
                set
                {
                    this.meetingContentTypeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorInitials
            {
                get
                {
                    return this.authorInitialsField;
                }
                set
                {
                    this.authorInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorResolutionID
            {
                get
                {
                    return this.authorResolutionIDField;
                }
                set
                {
                    this.authorResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedBy
            {
                get
                {
                    return this.lastModifiedByField;
                }
                set
                {
                    this.lastModifiedByField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByInitials
            {
                get
                {
                    return this.lastModifiedByInitialsField;
                }
                set
                {
                    this.lastModifiedByInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByResolutionID
            {
                get
                {
                    return this.lastModifiedByResolutionIDField;
                }
                set
                {
                    this.lastModifiedByResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime creationTime
            {
                get
                {
                    return this.creationTimeField;
                }
                set
                {
                    this.creationTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool creationTimeSpecified
            {
                get
                {
                    return this.creationTimeFieldSpecified;
                }
                set
                {
                    this.creationTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class OEChildren
        {

            private ChildOELayout childOELayoutField;

            private object[] itemsField;

            private string indentField;

            private string selectedField;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            public OEChildren()
            {
                this.indentField = "1";
                this.selectedField = "none";
            }

            /// <remarks/>
            public ChildOELayout ChildOELayout
            {
                get
                {
                    return this.childOELayoutField;
                }
                set
                {
                    this.childOELayoutField = value;
                }
            }

            /// <remarks/>
            [XmlElement("HTMLBlock", typeof(HtmlContent))]
            [XmlElement("OE", typeof(OE))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "positiveInteger")]
            [System.ComponentModel.DefaultValueAttribute("1")]
            public string indent
            {
                get
                {
                    return this.indentField;
                }
                set
                {
                    this.indentField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class ChildOELayout
        {

            private double spaceBeforeField;

            private bool spaceBeforeFieldSpecified;

            private double spaceBetweenField;

            private bool spaceBetweenFieldSpecified;

            private double spaceAfterField;

            private bool spaceAfterFieldSpecified;

            private double listSpacingField;

            private bool listSpacingFieldSpecified;

            private ChildOELayoutListAlignment listAlignmentField;

            private bool listAlignmentFieldSpecified;

            /// <remarks/>
            [XmlAttribute()]
            public double spaceBefore
            {
                get
                {
                    return this.spaceBeforeField;
                }
                set
                {
                    this.spaceBeforeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool spaceBeforeSpecified
            {
                get
                {
                    return this.spaceBeforeFieldSpecified;
                }
                set
                {
                    this.spaceBeforeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double spaceBetween
            {
                get
                {
                    return this.spaceBetweenField;
                }
                set
                {
                    this.spaceBetweenField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool spaceBetweenSpecified
            {
                get
                {
                    return this.spaceBetweenFieldSpecified;
                }
                set
                {
                    this.spaceBetweenFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double spaceAfter
            {
                get
                {
                    return this.spaceAfterField;
                }
                set
                {
                    this.spaceAfterField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool spaceAfterSpecified
            {
                get
                {
                    return this.spaceAfterFieldSpecified;
                }
                set
                {
                    this.spaceAfterFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double listSpacing
            {
                get
                {
                    return this.listSpacingField;
                }
                set
                {
                    this.listSpacingField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool listSpacingSpecified
            {
                get
                {
                    return this.listSpacingFieldSpecified;
                }
                set
                {
                    this.listSpacingFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public ChildOELayoutListAlignment listAlignment
            {
                get
                {
                    return this.listAlignmentField;
                }
                set
                {
                    this.listAlignmentField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool listAlignmentSpecified
            {
                get
                {
                    return this.listAlignmentFieldSpecified;
                }
                set
                {
                    this.listAlignmentFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public enum ChildOELayoutListAlignment
        {

            /// <remarks/>
            left,

            /// <remarks/>
            right,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class HtmlContent
        {

            private object itemField;

            private bool meetingTrackModificationsField;

            private bool meetingTrackModificationsFieldSpecified;

            /// <remarks/>
            [XmlElement("Data", typeof(string))]
            [XmlElement("File", typeof(FilePath))]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool meetingTrackModifications
            {
                get
                {
                    return this.meetingTrackModificationsField;
                }
                set
                {
                    this.meetingTrackModificationsField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool meetingTrackModificationsSpecified
            {
                get
                {
                    return this.meetingTrackModificationsFieldSpecified;
                }
                set
                {
                    this.meetingTrackModificationsFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class OE
        {

            private MediaIndex[] mediaIndexField;

            private Tag[] tagField;

            private OutlookTask outlookTaskField;

            private Tag[] tag1Field;

            private Meta[] metaField;

            private List listField;

            private object[] itemsField;

            private OEChildren[] oEChildrenField;

            private LinkedNote linkedNoteField;

            private bool rTLField;

            private bool rTLFieldSpecified;

            private bool bodyTextField;

            private bool collapsedField;

            private bool collapsedBodyTextField;

            private string alignmentField;

            private string selectedField;

            private string objectIDField;

            private double spaceBeforeField;

            private bool spaceBeforeFieldSpecified;

            private double spaceBetweenField;

            private bool spaceBetweenFieldSpecified;

            private double spaceAfterField;

            private bool spaceAfterFieldSpecified;

            private string meetingContentTypeField;

            private string meetingContentIdField;

            private bool meetingTrackModificationsField;

            private bool meetingTrackModificationsFieldSpecified;

            private bool meetingIsUserEditedField;

            private bool meetingIsUserEditedFieldSpecified;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            private string authorField;

            private string authorInitialsField;

            private string authorResolutionIDField;

            private string lastModifiedByField;

            private string lastModifiedByInitialsField;

            private string lastModifiedByResolutionIDField;

            private System.DateTime creationTimeField;

            private bool creationTimeFieldSpecified;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private bool preserveTextContentField;

            private bool preserveTextContentFieldSpecified;

            private bool explicitExpandCollapseEnabledField;

            private bool explicitExpandCollapseEnabledFieldSpecified;

            public OE()
            {
                this.bodyTextField = false;
                this.collapsedField = false;
                this.collapsedBodyTextField = false;
                this.alignmentField = "left";
                this.selectedField = "none";
            }

            /// <remarks/>
            [XmlElement("MediaIndex", Order = 0)]
            public MediaIndex[] MediaIndex
            {
                get
                {
                    return this.mediaIndexField;
                }
                set
                {
                    this.mediaIndexField = value;
                }
            }

            /// <remarks/>
            [XmlElement("Tag", Order = 1)]
            public Tag[] Tag
            {
                get
                {
                    return this.tagField;
                }
                set
                {
                    this.tagField = value;
                }
            }

            /// <remarks/>
            [XmlElement(Order = 2)]
            public OutlookTask OutlookTask
            {
                get
                {
                    return this.outlookTaskField;
                }
                set
                {
                    this.outlookTaskField = value;
                }
            }

            /// <remarks/>
            [XmlElement("Tag", Order = 3)]
            public Tag[] Tag1
            {
                get
                {
                    return this.tag1Field;
                }
                set
                {
                    this.tag1Field = value;
                }
            }

            /// <remarks/>
            [XmlElement("Meta", Order = 4)]
            public Meta[] Meta
            {
                get
                {
                    return this.metaField;
                }
                set
                {
                    this.metaField = value;
                }
            }

            /// <remarks/>
            [XmlElement(Order = 5)]
            public List List
            {
                get
                {
                    return this.listField;
                }
                set
                {
                    this.listField = value;
                }
            }

            /// <remarks/>
            [XmlElement("FutureObject", typeof(FutureObject), Order = 6)]
            [XmlElement("Image", typeof(Image), Order = 6)]
            [XmlElement("InkDrawing", typeof(InkDrawing), Order = 6)]
            [XmlElement("InkParagraph", typeof(InkParagraph), Order = 6)]
            [XmlElement("InkWord", typeof(InkWord), Order = 6)]
            [XmlElement("InsertedFile", typeof(InsertedFile), Order = 6)]
            [XmlElement("MediaFile", typeof(MediaFile), Order = 6)]
            [XmlElement("T", typeof(TextRange), Order = 6)]
            [XmlElement("Table", typeof(Table), Order = 6)]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [XmlElement("OEChildren", Order = 7)]
            public OEChildren[] OEChildren
            {
                get
                {
                    return this.oEChildrenField;
                }
                set
                {
                    this.oEChildrenField = value;
                }
            }

            /// <remarks/>
            [XmlElement(Order = 8)]
            public LinkedNote LinkedNote
            {
                get
                {
                    return this.linkedNoteField;
                }
                set
                {
                    this.linkedNoteField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool RTL
            {
                get
                {
                    return this.rTLField;
                }
                set
                {
                    this.rTLField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool RTLSpecified
            {
                get
                {
                    return this.rTLFieldSpecified;
                }
                set
                {
                    this.rTLFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool bodyText
            {
                get
                {
                    return this.bodyTextField;
                }
                set
                {
                    this.bodyTextField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool collapsed
            {
                get
                {
                    return this.collapsedField;
                }
                set
                {
                    this.collapsedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool collapsedBodyText
            {
                get
                {
                    return this.collapsedBodyTextField;
                }
                set
                {
                    this.collapsedBodyTextField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("left")]
            public string alignment
            {
                get
                {
                    return this.alignmentField;
                }
                set
                {
                    this.alignmentField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string objectID
            {
                get
                {
                    return this.objectIDField;
                }
                set
                {
                    this.objectIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double spaceBefore
            {
                get
                {
                    return this.spaceBeforeField;
                }
                set
                {
                    this.spaceBeforeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool spaceBeforeSpecified
            {
                get
                {
                    return this.spaceBeforeFieldSpecified;
                }
                set
                {
                    this.spaceBeforeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double spaceBetween
            {
                get
                {
                    return this.spaceBetweenField;
                }
                set
                {
                    this.spaceBetweenField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool spaceBetweenSpecified
            {
                get
                {
                    return this.spaceBetweenFieldSpecified;
                }
                set
                {
                    this.spaceBetweenFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double spaceAfter
            {
                get
                {
                    return this.spaceAfterField;
                }
                set
                {
                    this.spaceAfterField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool spaceAfterSpecified
            {
                get
                {
                    return this.spaceAfterFieldSpecified;
                }
                set
                {
                    this.spaceAfterFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string meetingContentType
            {
                get
                {
                    return this.meetingContentTypeField;
                }
                set
                {
                    this.meetingContentTypeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string meetingContentId
            {
                get
                {
                    return this.meetingContentIdField;
                }
                set
                {
                    this.meetingContentIdField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool meetingTrackModifications
            {
                get
                {
                    return this.meetingTrackModificationsField;
                }
                set
                {
                    this.meetingTrackModificationsField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool meetingTrackModificationsSpecified
            {
                get
                {
                    return this.meetingTrackModificationsFieldSpecified;
                }
                set
                {
                    this.meetingTrackModificationsFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool meetingIsUserEdited
            {
                get
                {
                    return this.meetingIsUserEditedField;
                }
                set
                {
                    this.meetingIsUserEditedField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool meetingIsUserEditedSpecified
            {
                get
                {
                    return this.meetingIsUserEditedFieldSpecified;
                }
                set
                {
                    this.meetingIsUserEditedFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorInitials
            {
                get
                {
                    return this.authorInitialsField;
                }
                set
                {
                    this.authorInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorResolutionID
            {
                get
                {
                    return this.authorResolutionIDField;
                }
                set
                {
                    this.authorResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedBy
            {
                get
                {
                    return this.lastModifiedByField;
                }
                set
                {
                    this.lastModifiedByField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByInitials
            {
                get
                {
                    return this.lastModifiedByInitialsField;
                }
                set
                {
                    this.lastModifiedByInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByResolutionID
            {
                get
                {
                    return this.lastModifiedByResolutionIDField;
                }
                set
                {
                    this.lastModifiedByResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime creationTime
            {
                get
                {
                    return this.creationTimeField;
                }
                set
                {
                    this.creationTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool creationTimeSpecified
            {
                get
                {
                    return this.creationTimeFieldSpecified;
                }
                set
                {
                    this.creationTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool preserveTextContent
            {
                get
                {
                    return this.preserveTextContentField;
                }
                set
                {
                    this.preserveTextContentField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool preserveTextContentSpecified
            {
                get
                {
                    return this.preserveTextContentFieldSpecified;
                }
                set
                {
                    this.preserveTextContentFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool explicitExpandCollapseEnabled
            {
                get
                {
                    return this.explicitExpandCollapseEnabledField;
                }
                set
                {
                    this.explicitExpandCollapseEnabledField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool explicitExpandCollapseEnabledSpecified
            {
                get
                {
                    return this.explicitExpandCollapseEnabledFieldSpecified;
                }
                set
                {
                    this.explicitExpandCollapseEnabledFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class MediaIndex
        {

            private MediaReference mediaReferenceField;

            private string timeIndexField;

            /// <remarks/>
            public MediaReference MediaReference
            {
                get
                {
                    return this.mediaReferenceField;
                }
                set
                {
                    this.mediaReferenceField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string timeIndex
            {
                get
                {
                    return this.timeIndexField;
                }
                set
                {
                    this.timeIndexField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class MediaReference
        {

            private string mediaIDField;

            /// <remarks/>
            [XmlAttribute()]
            public string mediaID
            {
                get
                {
                    return this.mediaIDField;
                }
                set
                {
                    this.mediaIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Tag
        {

            private string indexField;

            private bool completedField;

            private bool disabledField;

            private System.DateTime creationDateField;

            private bool creationDateFieldSpecified;

            private System.DateTime completionDateField;

            private bool completionDateFieldSpecified;

            public Tag()
            {
                this.completedField = false;
                this.disabledField = false;
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string index
            {
                get
                {
                    return this.indexField;
                }
                set
                {
                    this.indexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool completed
            {
                get
                {
                    return this.completedField;
                }
                set
                {
                    this.completedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool disabled
            {
                get
                {
                    return this.disabledField;
                }
                set
                {
                    this.disabledField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime creationDate
            {
                get
                {
                    return this.creationDateField;
                }
                set
                {
                    this.creationDateField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool creationDateSpecified
            {
                get
                {
                    return this.creationDateFieldSpecified;
                }
                set
                {
                    this.creationDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime completionDate
            {
                get
                {
                    return this.completionDateField;
                }
                set
                {
                    this.completionDateField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool completionDateSpecified
            {
                get
                {
                    return this.completionDateFieldSpecified;
                }
                set
                {
                    this.completionDateFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class OutlookTask
        {

            private bool completedField;

            private bool disabledField;

            private System.DateTime creationDateField;

            private bool creationDateFieldSpecified;

            private System.DateTime completionDateField;

            private bool completionDateFieldSpecified;

            private System.DateTime startDateField;

            private bool startDateFieldSpecified;

            private System.DateTime dueDateField;

            private bool dueDateFieldSpecified;

            private string guidTaskField;

            public OutlookTask()
            {
                this.completedField = false;
                this.disabledField = false;
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool completed
            {
                get
                {
                    return this.completedField;
                }
                set
                {
                    this.completedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool disabled
            {
                get
                {
                    return this.disabledField;
                }
                set
                {
                    this.disabledField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime creationDate
            {
                get
                {
                    return this.creationDateField;
                }
                set
                {
                    this.creationDateField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool creationDateSpecified
            {
                get
                {
                    return this.creationDateFieldSpecified;
                }
                set
                {
                    this.creationDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime completionDate
            {
                get
                {
                    return this.completionDateField;
                }
                set
                {
                    this.completionDateField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool completionDateSpecified
            {
                get
                {
                    return this.completionDateFieldSpecified;
                }
                set
                {
                    this.completionDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime startDate
            {
                get
                {
                    return this.startDateField;
                }
                set
                {
                    this.startDateField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool startDateSpecified
            {
                get
                {
                    return this.startDateFieldSpecified;
                }
                set
                {
                    this.startDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime dueDate
            {
                get
                {
                    return this.dueDateField;
                }
                set
                {
                    this.dueDateField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool dueDateSpecified
            {
                get
                {
                    return this.dueDateFieldSpecified;
                }
                set
                {
                    this.dueDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string guidTask
            {
                get
                {
                    return this.guidTaskField;
                }
                set
                {
                    this.guidTaskField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Meta
        {

            private string nameField;

            private string contentField;

            /// <remarks/>
            [XmlAttribute()]
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
            [XmlAttribute()]
            public string content
            {
                get
                {
                    return this.contentField;
                }
                set
                {
                    this.contentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class List
        {

            private object itemField;

            /// <remarks/>
            [XmlElement("Bullet", typeof(Bullet))]
            [XmlElement("Number", typeof(Number))]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Bullet
        {

            private string bulletField;

            private double fontSizeField;

            private string fontColorField;

            public Bullet()
            {
                this.fontSizeField = 10D;
                this.fontColorField = "automatic";
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string bullet
            {
                get
                {
                    return this.bulletField;
                }
                set
                {
                    this.bulletField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(10D)]
            public double fontSize
            {
                get
                {
                    return this.fontSizeField;
                }
                set
                {
                    this.fontSizeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string fontColor
            {
                get
                {
                    return this.fontColorField;
                }
                set
                {
                    this.fontColorField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Number
        {

            private string numberSequenceField;

            private string numberFormatField;

            private string restartNumberingAtField;

            private string fontField;

            private double fontSizeField;

            private string fontColorField;

            private bool boldField;

            private bool italicField;

            private string languageField;

            private string textField;

            public Number()
            {
                this.fontField = "Verdana";
                this.fontSizeField = 10D;
                this.fontColorField = "automatic";
                this.boldField = false;
                this.italicField = false;
                this.languageField = "1033";
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string numberSequence
            {
                get
                {
                    return this.numberSequenceField;
                }
                set
                {
                    this.numberSequenceField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string numberFormat
            {
                get
                {
                    return this.numberFormatField;
                }
                set
                {
                    this.numberFormatField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string restartNumberingAt
            {
                get
                {
                    return this.restartNumberingAtField;
                }
                set
                {
                    this.restartNumberingAtField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("Verdana")]
            public string font
            {
                get
                {
                    return this.fontField;
                }
                set
                {
                    this.fontField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(10D)]
            public double fontSize
            {
                get
                {
                    return this.fontSizeField;
                }
                set
                {
                    this.fontSizeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string fontColor
            {
                get
                {
                    return this.fontColorField;
                }
                set
                {
                    this.fontColorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool bold
            {
                get
                {
                    return this.boldField;
                }
                set
                {
                    this.boldField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool italic
            {
                get
                {
                    return this.italicField;
                }
                set
                {
                    this.italicField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("1033")]
            public string language
            {
                get
                {
                    return this.languageField;
                }
                set
                {
                    this.languageField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class FutureObject : PageObjectTagable
        {
        }

        /// <remarks/>
        [XmlInclude(typeof(FutureObject))]
        [XmlInclude(typeof(Image))]
        [XmlInclude(typeof(InsertedFile))]
        [XmlInclude(typeof(MediaFile))]
        [XmlInclude(typeof(InkDrawing))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class PageObjectTagable : PageObject
        {

            private MediaIndex[] mediaIndexField;

            private Tag[] tagField;

            private OutlookTask outlookTaskField;

            private Tag[] tag1Field;

            /// <remarks/>
            [XmlElement("MediaIndex", Order = 0)]
            public MediaIndex[] MediaIndex
            {
                get
                {
                    return this.mediaIndexField;
                }
                set
                {
                    this.mediaIndexField = value;
                }
            }

            /// <remarks/>
            [XmlElement("Tag", Order = 1)]
            public Tag[] Tag
            {
                get
                {
                    return this.tagField;
                }
                set
                {
                    this.tagField = value;
                }
            }

            /// <remarks/>
            [XmlElement(Order = 2)]
            public OutlookTask OutlookTask
            {
                get
                {
                    return this.outlookTaskField;
                }
                set
                {
                    this.outlookTaskField = value;
                }
            }

            /// <remarks/>
            [XmlElement("Tag", Order = 3)]
            public Tag[] Tag1
            {
                get
                {
                    return this.tag1Field;
                }
                set
                {
                    this.tag1Field = value;
                }
            }
        }

        /// <remarks/>
        [XmlInclude(typeof(Outline))]
        [XmlInclude(typeof(PageObjectTagable))]
        [XmlInclude(typeof(FutureObject))]
        [XmlInclude(typeof(Image))]
        [XmlInclude(typeof(InsertedFile))]
        [XmlInclude(typeof(MediaFile))]
        [XmlInclude(typeof(InkDrawing))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class PageObject
        {

            private Position positionField;

            private Size sizeField;

            private Meta[] metaField;

            private string objectIDField;

            private string selectedField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            public PageObject()
            {
                this.selectedField = "none";
            }

            /// <remarks/>
            [XmlElement(Order = 0)]
            public Position Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            [XmlElement(Order = 1)]
            public Size Size
            {
                get
                {
                    return this.sizeField;
                }
                set
                {
                    this.sizeField = value;
                }
            }

            /// <remarks/>
            [XmlElement("Meta", Order = 2)]
            public Meta[] Meta
            {
                get
                {
                    return this.metaField;
                }
                set
                {
                    this.metaField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string objectID
            {
                get
                {
                    return this.objectIDField;
                }
                set
                {
                    this.objectIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Position
        {

            private double xField;

            private double yField;

            private string zField;

            /// <remarks/>
            [XmlAttribute()]
            public double x
            {
                get
                {
                    return this.xField;
                }
                set
                {
                    this.xField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string z
            {
                get
                {
                    return this.zField;
                }
                set
                {
                    this.zField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Size
        {

            private double widthField;

            private double heightField;

            private bool isSetByUserField;

            private bool isSetByUserFieldSpecified;

            /// <remarks/>
            [XmlAttribute()]
            public double width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool isSetByUser
            {
                get
                {
                    return this.isSetByUserField;
                }
                set
                {
                    this.isSetByUserField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool isSetByUserSpecified
            {
                get
                {
                    return this.isSetByUserFieldSpecified;
                }
                set
                {
                    this.isSetByUserFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Outline : PageObject
        {

            private Indent[] indentsField;

            private OEChildren[] oEChildrenField;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            private string authorField;

            private string authorInitialsField;

            private string authorResolutionIDField;

            private string lastModifiedByField;

            private string lastModifiedByInitialsField;

            private string lastModifiedByResolutionIDField;

            private System.DateTime creationTimeField;

            private bool creationTimeFieldSpecified;

            /// <remarks/>
            [XmlArray(Order = 0)]
            [XmlArrayItem(IsNullable = false)]
            public Indent[] Indents
            {
                get
                {
                    return this.indentsField;
                }
                set
                {
                    this.indentsField = value;
                }
            }

            /// <remarks/>
            [XmlElement("OEChildren", Order = 1)]
            public OEChildren[] OEChildren
            {
                get
                {
                    return this.oEChildrenField;
                }
                set
                {
                    this.oEChildrenField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorInitials
            {
                get
                {
                    return this.authorInitialsField;
                }
                set
                {
                    this.authorInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorResolutionID
            {
                get
                {
                    return this.authorResolutionIDField;
                }
                set
                {
                    this.authorResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedBy
            {
                get
                {
                    return this.lastModifiedByField;
                }
                set
                {
                    this.lastModifiedByField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByInitials
            {
                get
                {
                    return this.lastModifiedByInitialsField;
                }
                set
                {
                    this.lastModifiedByInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByResolutionID
            {
                get
                {
                    return this.lastModifiedByResolutionIDField;
                }
                set
                {
                    this.lastModifiedByResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime creationTime
            {
                get
                {
                    return this.creationTimeField;
                }
                set
                {
                    this.creationTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool creationTimeSpecified
            {
                get
                {
                    return this.creationTimeFieldSpecified;
                }
                set
                {
                    this.creationTimeFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Indent
        {

            private string levelField;

            private double indentField;

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string level
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
            [XmlAttribute()]
            public double indent
            {
                get
                {
                    return this.indentField;
                }
                set
                {
                    this.indentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Image : PageObjectTagable
        {

            private object itemField;

            private OCRData oCRDataField;

            private Preview previewField;

            private string formatField;

            private string xpsFileIndexField;

            private string originalDocumentNumberField;

            private string originalPageNumberField;

            private bool isPrintOutField;

            private bool backgroundImageField;

            private string hyperlinkField;

            private string altField;

            private string sourceDocumentField;

            public Image()
            {
                this.formatField = "auto";
                this.originalDocumentNumberField = "0";
                this.originalPageNumberField = "0";
                this.isPrintOutField = false;
                this.backgroundImageField = false;
            }

            /// <remarks/>
            [XmlElement("CallbackID", typeof(CallbackID), Order = 0)]
            [XmlElement("Data", typeof(byte[]), DataType = "base64Binary", Order = 0)]
            [XmlElement("File", typeof(FilePath), Order = 0)]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [XmlElement(Order = 1)]
            public OCRData OCRData
            {
                get
                {
                    return this.oCRDataField;
                }
                set
                {
                    this.oCRDataField = value;
                }
            }

            /// <remarks/>
            [XmlElement(Order = 2)]
            public Preview Preview
            {
                get
                {
                    return this.previewField;
                }
                set
                {
                    this.previewField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("auto")]
            public string format
            {
                get
                {
                    return this.formatField;
                }
                set
                {
                    this.formatField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string xpsFileIndex
            {
                get
                {
                    return this.xpsFileIndexField;
                }
                set
                {
                    this.xpsFileIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            [System.ComponentModel.DefaultValueAttribute("0")]
            public string originalDocumentNumber
            {
                get
                {
                    return this.originalDocumentNumberField;
                }
                set
                {
                    this.originalDocumentNumberField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            [System.ComponentModel.DefaultValueAttribute("0")]
            public string originalPageNumber
            {
                get
                {
                    return this.originalPageNumberField;
                }
                set
                {
                    this.originalPageNumberField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isPrintOut
            {
                get
                {
                    return this.isPrintOutField;
                }
                set
                {
                    this.isPrintOutField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool backgroundImage
            {
                get
                {
                    return this.backgroundImageField;
                }
                set
                {
                    this.backgroundImageField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string hyperlink
            {
                get
                {
                    return this.hyperlinkField;
                }
                set
                {
                    this.hyperlinkField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string alt
            {
                get
                {
                    return this.altField;
                }
                set
                {
                    this.altField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string sourceDocument
            {
                get
                {
                    return this.sourceDocumentField;
                }
                set
                {
                    this.sourceDocumentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class OCRData
        {

            private string oCRTextField;

            private OCRToken[] oCRTokenField;

            private string langField;

            public OCRData()
            {
                this.langField = "EN-US";
            }

            /// <remarks/>
            public string OCRText
            {
                get
                {
                    return this.oCRTextField;
                }
                set
                {
                    this.oCRTextField = value;
                }
            }

            /// <remarks/>
            [XmlElement("OCRToken")]
            public OCRToken[] OCRToken
            {
                get
                {
                    return this.oCRTokenField;
                }
                set
                {
                    this.oCRTokenField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("EN-US")]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class OCRToken
        {

            private string startPosField;

            private string regionField;

            private string lineField;

            private decimal xField;

            private decimal yField;

            private double widthField;

            private double heightField;

            public OCRToken()
            {
                this.regionField = "0";
                this.lineField = "0";
                this.xField = ((decimal)(0m));
                this.yField = ((decimal)(0m));
                this.widthField = 0D;
                this.heightField = 0D;
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string startPos
            {
                get
                {
                    return this.startPosField;
                }
                set
                {
                    this.startPosField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            [System.ComponentModel.DefaultValueAttribute("0")]
            public string region
            {
                get
                {
                    return this.regionField;
                }
                set
                {
                    this.regionField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            [System.ComponentModel.DefaultValueAttribute("0")]
            public string line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(decimal), "0")]
            public decimal x
            {
                get
                {
                    return this.xField;
                }
                set
                {
                    this.xField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(decimal), "0")]
            public decimal y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(0D)]
            public double width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(0D)]
            public double height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Preview
        {

            private string pageField;

            private string objectField;

            private string rangeField;

            /// <remarks/>
            [XmlAttribute()]
            public string page
            {
                get
                {
                    return this.pageField;
                }
                set
                {
                    this.pageField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string @object
            {
                get
                {
                    return this.objectField;
                }
                set
                {
                    this.objectField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string range
            {
                get
                {
                    return this.rangeField;
                }
                set
                {
                    this.rangeField = value;
                }
            }
        }

        /// <remarks/>
        [XmlInclude(typeof(MediaFile))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class InsertedFile : PageObjectTagable
        {

            private object itemField;

            private string pathSourceField;

            private string pathCacheField;

            private string preferredNameField;

            /// <remarks/>
            [XmlElement("Previews", typeof(Previews), Order = 0)]
            [XmlElement("Printout", typeof(Printout), Order = 0)]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string pathSource
            {
                get
                {
                    return this.pathSourceField;
                }
                set
                {
                    this.pathSourceField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string pathCache
            {
                get
                {
                    return this.pathCacheField;
                }
                set
                {
                    this.pathCacheField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string preferredName
            {
                get
                {
                    return this.preferredNameField;
                }
                set
                {
                    this.preferredNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Previews
        {

            private Preview[] previewField;

            private string sourceDocumentField;

            private bool displayAllField;

            public Previews()
            {
                this.displayAllField = false;
            }

            /// <remarks/>
            [XmlElement("Preview")]
            public Preview[] Preview
            {
                get
                {
                    return this.previewField;
                }
                set
                {
                    this.previewField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string sourceDocument
            {
                get
                {
                    return this.sourceDocumentField;
                }
                set
                {
                    this.sourceDocumentField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool displayAll
            {
                get
                {
                    return this.displayAllField;
                }
                set
                {
                    this.displayAllField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Printout
        {

            private string xpsFileIndexField;

            private bool outOfDateField;

            public Printout()
            {
                this.outOfDateField = false;
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string xpsFileIndex
            {
                get
                {
                    return this.xpsFileIndexField;
                }
                set
                {
                    this.xpsFileIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool outOfDate
            {
                get
                {
                    return this.outOfDateField;
                }
                set
                {
                    this.outOfDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class MediaFile : InsertedFile
        {

            private MediaReference mediaReferenceField;

            /// <remarks/>
            [XmlElement(Order = 0)]
            public MediaReference MediaReference
            {
                get
                {
                    return this.mediaReferenceField;
                }
                set
                {
                    this.mediaReferenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class InkDrawing : PageObjectTagable
        {

            private ShapeInfo shapeInfoField;

            private object itemField;

            private bool isUnclassifiedField;

            private double inkOriginXField;

            private double inkOriginYField;

            public InkDrawing()
            {
                this.isUnclassifiedField = false;
                this.inkOriginXField = 0D;
                this.inkOriginYField = 0D;
            }

            /// <remarks/>
            [XmlElement(Order = 0)]
            public ShapeInfo ShapeInfo
            {
                get
                {
                    return this.shapeInfoField;
                }
                set
                {
                    this.shapeInfoField = value;
                }
            }

            /// <remarks/>
            [XmlElement("CallbackID", typeof(CallbackID), Order = 1)]
            [XmlElement("Data", typeof(byte[]), DataType = "base64Binary", Order = 1)]
            [XmlElement("File", typeof(FilePath), Order = 1)]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isUnclassified
            {
                get
                {
                    return this.isUnclassifiedField;
                }
                set
                {
                    this.isUnclassifiedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(0D)]
            public double inkOriginX
            {
                get
                {
                    return this.inkOriginXField;
                }
                set
                {
                    this.inkOriginXField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(0D)]
            public double inkOriginY
            {
                get
                {
                    return this.inkOriginYField;
                }
                set
                {
                    this.inkOriginYField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class ShapeInfo
        {

            private AnchorPoint[] anchorPointField;

            private bool isLineField;

            public ShapeInfo()
            {
                this.isLineField = false;
            }

            /// <remarks/>
            [XmlElement("AnchorPoint")]
            public AnchorPoint[] AnchorPoint
            {
                get
                {
                    return this.anchorPointField;
                }
                set
                {
                    this.anchorPointField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isLine
            {
                get
                {
                    return this.isLineField;
                }
                set
                {
                    this.isLineField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class AnchorPoint
        {

            private double xField;

            private double yField;

            /// <remarks/>
            [XmlAttribute()]
            public double x
            {
                get
                {
                    return this.xField;
                }
                set
                {
                    this.xField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Table
        {

            private Column[] columnsField;

            private Row[] rowField;

            private string objectIDField;

            private bool bordersVisibleField;

            private bool hasHeaderRowField;

            private string selectedField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private string meetingContentTypeField;

            private string authorField;

            private string authorInitialsField;

            private string authorResolutionIDField;

            private string lastModifiedByField;

            private string lastModifiedByInitialsField;

            private string lastModifiedByResolutionIDField;

            private System.DateTime creationTimeField;

            private bool creationTimeFieldSpecified;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            public Table()
            {
                this.bordersVisibleField = false;
                this.hasHeaderRowField = false;
                this.selectedField = "none";
            }

            /// <remarks/>
            [XmlArrayItem(IsNullable = false)]
            public Column[] Columns
            {
                get
                {
                    return this.columnsField;
                }
                set
                {
                    this.columnsField = value;
                }
            }

            /// <remarks/>
            [XmlElement("Row")]
            public Row[] Row
            {
                get
                {
                    return this.rowField;
                }
                set
                {
                    this.rowField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string objectID
            {
                get
                {
                    return this.objectIDField;
                }
                set
                {
                    this.objectIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool bordersVisible
            {
                get
                {
                    return this.bordersVisibleField;
                }
                set
                {
                    this.bordersVisibleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool hasHeaderRow
            {
                get
                {
                    return this.hasHeaderRowField;
                }
                set
                {
                    this.hasHeaderRowField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string meetingContentType
            {
                get
                {
                    return this.meetingContentTypeField;
                }
                set
                {
                    this.meetingContentTypeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorInitials
            {
                get
                {
                    return this.authorInitialsField;
                }
                set
                {
                    this.authorInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorResolutionID
            {
                get
                {
                    return this.authorResolutionIDField;
                }
                set
                {
                    this.authorResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedBy
            {
                get
                {
                    return this.lastModifiedByField;
                }
                set
                {
                    this.lastModifiedByField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByInitials
            {
                get
                {
                    return this.lastModifiedByInitialsField;
                }
                set
                {
                    this.lastModifiedByInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByResolutionID
            {
                get
                {
                    return this.lastModifiedByResolutionIDField;
                }
                set
                {
                    this.lastModifiedByResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime creationTime
            {
                get
                {
                    return this.creationTimeField;
                }
                set
                {
                    this.creationTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool creationTimeSpecified
            {
                get
                {
                    return this.creationTimeFieldSpecified;
                }
                set
                {
                    this.creationTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Column
        {

            private string indexField;

            private double widthField;

            private bool isLockedField;

            public Column()
            {
                this.isLockedField = false;
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string index
            {
                get
                {
                    return this.indexField;
                }
                set
                {
                    this.indexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isLocked
            {
                get
                {
                    return this.isLockedField;
                }
                set
                {
                    this.isLockedField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Row
        {

            private Cell[] cellField;

            private string objectIDField;

            private string selectedField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private string meetingContentTypeField;

            private string meetingContentIdField;

            private string authorField;

            private string authorInitialsField;

            private string authorResolutionIDField;

            private string lastModifiedByField;

            private string lastModifiedByInitialsField;

            private string lastModifiedByResolutionIDField;

            private System.DateTime creationTimeField;

            private bool creationTimeFieldSpecified;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            public Row()
            {
                this.selectedField = "none";
            }

            /// <remarks/>
            [XmlElement("Cell")]
            public Cell[] Cell
            {
                get
                {
                    return this.cellField;
                }
                set
                {
                    this.cellField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string objectID
            {
                get
                {
                    return this.objectIDField;
                }
                set
                {
                    this.objectIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string meetingContentType
            {
                get
                {
                    return this.meetingContentTypeField;
                }
                set
                {
                    this.meetingContentTypeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string meetingContentId
            {
                get
                {
                    return this.meetingContentIdField;
                }
                set
                {
                    this.meetingContentIdField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorInitials
            {
                get
                {
                    return this.authorInitialsField;
                }
                set
                {
                    this.authorInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string authorResolutionID
            {
                get
                {
                    return this.authorResolutionIDField;
                }
                set
                {
                    this.authorResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedBy
            {
                get
                {
                    return this.lastModifiedByField;
                }
                set
                {
                    this.lastModifiedByField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByInitials
            {
                get
                {
                    return this.lastModifiedByInitialsField;
                }
                set
                {
                    this.lastModifiedByInitialsField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lastModifiedByResolutionID
            {
                get
                {
                    return this.lastModifiedByResolutionIDField;
                }
                set
                {
                    this.lastModifiedByResolutionIDField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime creationTime
            {
                get
                {
                    return this.creationTimeField;
                }
                set
                {
                    this.creationTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool creationTimeSpecified
            {
                get
                {
                    return this.creationTimeFieldSpecified;
                }
                set
                {
                    this.creationTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Title
        {

            private OE[] oeField;

            private string selectedField;

            private string styleField;

            private string quickStyleIndexField;

            private string langField;

            private bool showDateField;

            private bool showTimeField;

            public Title()
            {
                this.selectedField = "none";
                this.showDateField = true;
                this.showTimeField = true;
            }

            /// <remarks/>
            [XmlElement("OE")]
            public OE[] OE
            {
                get
                {
                    return this.oeField;
                }
                set
                {
                    this.oeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("none")]
            public string selected
            {
                get
                {
                    return this.selectedField;
                }
                set
                {
                    this.selectedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string quickStyleIndex
            {
                get
                {
                    return this.quickStyleIndexField;
                }
                set
                {
                    this.quickStyleIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool showDate
            {
                get
                {
                    return this.showDateField;
                }
                set
                {
                    this.showDateField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool showTime
            {
                get
                {
                    return this.showTimeField;
                }
                set
                {
                    this.showTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class RuleMarginSettings
        {

            private string colorField;

            public RuleMarginSettings()
            {
                this.colorField = "automatic";
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class RuleLineSettings
        {

            private string colorField;

            private double spacingField;

            public RuleLineSettings()
            {
                this.colorField = "automatic";
                this.spacingField = 23.76D;
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(23.76D)]
            public double spacing
            {
                get
                {
                    return this.spacingField;
                }
                set
                {
                    this.spacingField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class RuleLines
        {

            private object[] itemsField;

            private ItemsChoiceType[] itemsElementNameField;

            private bool visibleField;

            /// <remarks/>
            [XmlElement("Automatic", typeof(Automatic))]
            [XmlElement("Horizontal", typeof(RuleLineSettings))]
            [XmlElement("Margin", typeof(RuleMarginSettings))]
            [XmlElement("Vertical", typeof(RuleLineSettings))]
            [XmlChoiceIdentifier("ItemsElementName")]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [XmlElement("ItemsElementName")]
            [XmlIgnore()]
            public ItemsChoiceType[] ItemsElementName
            {
                get
                {
                    return this.itemsElementNameField;
                }
                set
                {
                    this.itemsElementNameField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool visible
            {
                get
                {
                    return this.visibleField;
                }
                set
                {
                    this.visibleField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class Automatic
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IncludeInSchema = false)]
        public enum ItemsChoiceType
        {

            /// <remarks/>
            Automatic,

            /// <remarks/>
            Horizontal,

            /// <remarks/>
            Margin,

            /// <remarks/>
            Vertical,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class PageMargins
        {

            private double topField;

            private double bottomField;

            private double leftField;

            private double rightField;

            public PageMargins()
            {
                this.topField = 36D;
                this.bottomField = 36D;
                this.leftField = 72D;
                this.rightField = 72D;
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(36D)]
            public double top
            {
                get
                {
                    return this.topField;
                }
                set
                {
                    this.topField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(36D)]
            public double bottom
            {
                get
                {
                    return this.bottomField;
                }
                set
                {
                    this.bottomField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(72D)]
            public double left
            {
                get
                {
                    return this.leftField;
                }
                set
                {
                    this.leftField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(72D)]
            public double right
            {
                get
                {
                    return this.rightField;
                }
                set
                {
                    this.rightField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class PageDimensions
        {

            private double heightField;

            private double widthField;

            public PageDimensions()
            {
                this.heightField = 792D;
                this.widthField = 612D;
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(792D)]
            public double height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(612D)]
            public double width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class PageOrientation
        {

            private bool landscapeField;

            public PageOrientation()
            {
                this.landscapeField = false;
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool landscape
            {
                get
                {
                    return this.landscapeField;
                }
                set
                {
                    this.landscapeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class PageSize
        {

            private object[] itemsField;

            /// <remarks/>
            [XmlElement("Automatic", typeof(Automatic))]
            [XmlElement("Dimensions", typeof(PageDimensions))]
            [XmlElement("Margins", typeof(PageMargins))]
            [XmlElement("Orientation", typeof(PageOrientation))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class PageSettings
        {

            private PageSize pageSizeField;

            private RuleLines ruleLinesField;

            private bool rTLField;

            private string colorField;

            public PageSettings()
            {
                this.rTLField = false;
                this.colorField = "automatic";
            }

            /// <remarks/>
            public PageSize PageSize
            {
                get
                {
                    return this.pageSizeField;
                }
                set
                {
                    this.pageSizeField = value;
                }
            }

            /// <remarks/>
            public RuleLines RuleLines
            {
                get
                {
                    return this.ruleLinesField;
                }
                set
                {
                    this.ruleLinesField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool RTL
            {
                get
                {
                    return this.rTLField;
                }
                set
                {
                    this.rTLField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class MeetingInfo
        {

            private string broadcastUrlField;

            private bool broadcastActiveField;

            private bool broadcastActiveFieldSpecified;

            private string iMConversationIdField;

            private string iMConversationUpdaterField;

            private string iMConversationTypeField;

            private string meetingGlobalAppointmentIdField;

            private System.DateTime meetingStartTimeField;

            private bool meetingStartTimeFieldSpecified;

            private System.DateTime meetingEndTimeField;

            private bool meetingEndTimeFieldSpecified;

            private string meetingRecurrenceTypeField;

            private bool outlookSharedNotesField;

            private bool outlookSharedNotesFieldSpecified;

            /// <remarks/>
            [XmlAttribute()]
            public string broadcastUrl
            {
                get
                {
                    return this.broadcastUrlField;
                }
                set
                {
                    this.broadcastUrlField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool broadcastActive
            {
                get
                {
                    return this.broadcastActiveField;
                }
                set
                {
                    this.broadcastActiveField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool broadcastActiveSpecified
            {
                get
                {
                    return this.broadcastActiveFieldSpecified;
                }
                set
                {
                    this.broadcastActiveFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string IMConversationId
            {
                get
                {
                    return this.iMConversationIdField;
                }
                set
                {
                    this.iMConversationIdField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string IMConversationUpdater
            {
                get
                {
                    return this.iMConversationUpdaterField;
                }
                set
                {
                    this.iMConversationUpdaterField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string IMConversationType
            {
                get
                {
                    return this.iMConversationTypeField;
                }
                set
                {
                    this.iMConversationTypeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string meetingGlobalAppointmentId
            {
                get
                {
                    return this.meetingGlobalAppointmentIdField;
                }
                set
                {
                    this.meetingGlobalAppointmentIdField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime meetingStartTime
            {
                get
                {
                    return this.meetingStartTimeField;
                }
                set
                {
                    this.meetingStartTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool meetingStartTimeSpecified
            {
                get
                {
                    return this.meetingStartTimeFieldSpecified;
                }
                set
                {
                    this.meetingStartTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public System.DateTime meetingEndTime
            {
                get
                {
                    return this.meetingEndTimeField;
                }
                set
                {
                    this.meetingEndTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool meetingEndTimeSpecified
            {
                get
                {
                    return this.meetingEndTimeFieldSpecified;
                }
                set
                {
                    this.meetingEndTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string meetingRecurrenceType
            {
                get
                {
                    return this.meetingRecurrenceTypeField;
                }
                set
                {
                    this.meetingRecurrenceTypeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool outlookSharedNotes
            {
                get
                {
                    return this.outlookSharedNotesField;
                }
                set
                {
                    this.outlookSharedNotesField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool outlookSharedNotesSpecified
            {
                get
                {
                    return this.outlookSharedNotesFieldSpecified;
                }
                set
                {
                    this.outlookSharedNotesFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class XPSFile
        {

            private object itemField;

            private string xpsFileIndexField;

            private string idDocumentField;

            /// <remarks/>
            [XmlElement("CallbackID", typeof(CallbackID))]
            [XmlElement("Data", typeof(byte[]), DataType = "base64Binary")]
            [XmlElement("File", typeof(FilePath))]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string xpsFileIndex
            {
                get
                {
                    return this.xpsFileIndexField;
                }
                set
                {
                    this.xpsFileIndexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string idDocument
            {
                get
                {
                    return this.idDocumentField;
                }
                set
                {
                    this.idDocumentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        public partial class QuickStyleDef
        {

            private string indexField;

            private string nameField;

            private string fontColorField;

            private string highlightColorField;

            private string fontField;

            private double fontSizeField;

            private bool boldField;

            private bool italicField;

            private bool underlineField;

            private bool strikethroughField;

            private bool superscriptField;

            private bool subscriptField;

            private float spaceBeforeField;

            private float spaceAfterField;

            public QuickStyleDef()
            {
                this.fontColorField = "automatic";
                this.highlightColorField = "automatic";
                this.boldField = false;
                this.italicField = false;
                this.underlineField = false;
                this.strikethroughField = false;
                this.superscriptField = false;
                this.subscriptField = false;
                this.spaceBeforeField = ((float)(0F));
                this.spaceAfterField = ((float)(0F));
            }

            /// <remarks/>
            [XmlAttribute(DataType = "nonNegativeInteger")]
            public string index
            {
                get
                {
                    return this.indexField;
                }
                set
                {
                    this.indexField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
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
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string fontColor
            {
                get
                {
                    return this.fontColorField;
                }
                set
                {
                    this.fontColorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute("automatic")]
            public string highlightColor
            {
                get
                {
                    return this.highlightColorField;
                }
                set
                {
                    this.highlightColorField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string font
            {
                get
                {
                    return this.fontField;
                }
                set
                {
                    this.fontField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public double fontSize
            {
                get
                {
                    return this.fontSizeField;
                }
                set
                {
                    this.fontSizeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool bold
            {
                get
                {
                    return this.boldField;
                }
                set
                {
                    this.boldField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool italic
            {
                get
                {
                    return this.italicField;
                }
                set
                {
                    this.italicField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool underline
            {
                get
                {
                    return this.underlineField;
                }
                set
                {
                    this.underlineField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool strikethrough
            {
                get
                {
                    return this.strikethroughField;
                }
                set
                {
                    this.strikethroughField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool superscript
            {
                get
                {
                    return this.superscriptField;
                }
                set
                {
                    this.superscriptField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool subscript
            {
                get
                {
                    return this.subscriptField;
                }
                set
                {
                    this.subscriptField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
            public float spaceBefore
            {
                get
                {
                    return this.spaceBeforeField;
                }
                set
                {
                    this.spaceBeforeField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
            public float spaceAfter
            {
                get
                {
                    return this.spaceAfterField;
                }
                set
                {
                    this.spaceAfterField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        [XmlRoot(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
        public partial class SectionGroup
        {

            private Section[] sectionField;

            private SectionGroup[] sectionGroup1Field;

            private bool isUnreadField;

            private bool isUnreadFieldSpecified;

            private bool isRecycleBinField;

            private string idField;

            private string nameField;

            private System.DateTime lastModifiedTimeField;

            private bool lastModifiedTimeFieldSpecified;

            private bool isCurrentlyViewedField;

            private bool isInRecycleBinField;

            private string pathField;

            public SectionGroup()
            {
                this.isRecycleBinField = false;
                this.isCurrentlyViewedField = false;
                this.isInRecycleBinField = false;
            }

            /// <remarks/>
            [XmlElement("Section")]
            public Section[] Section
            {
                get
                {
                    return this.sectionField;
                }
                set
                {
                    this.sectionField = value;
                }
            }

            /// <remarks/>
            [XmlElement("SectionGroup")]
            public SectionGroup[] SectionGroup1
            {
                get
                {
                    return this.sectionGroup1Field;
                }
                set
                {
                    this.sectionGroup1Field = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public bool isUnread
            {
                get
                {
                    return this.isUnreadField;
                }
                set
                {
                    this.isUnreadField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool isUnreadSpecified
            {
                get
                {
                    return this.isUnreadFieldSpecified;
                }
                set
                {
                    this.isUnreadFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isRecycleBin
            {
                get
                {
                    return this.isRecycleBinField;
                }
                set
                {
                    this.isRecycleBinField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string ID
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

            /// <remarks/>
            [XmlAttribute()]
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
            [XmlAttribute()]
            public System.DateTime lastModifiedTime
            {
                get
                {
                    return this.lastModifiedTimeField;
                }
                set
                {
                    this.lastModifiedTimeField = value;
                }
            }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastModifiedTimeSpecified
            {
                get
                {
                    return this.lastModifiedTimeFieldSpecified;
                }
                set
                {
                    this.lastModifiedTimeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isCurrentlyViewed
            {
                get
                {
                    return this.isCurrentlyViewedField;
                }
                set
                {
                    this.isCurrentlyViewedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isInRecycleBin
            {
                get
                {
                    return this.isInRecycleBinField;
                }
                set
                {
                    this.isInRecycleBinField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string path
            {
                get
                {
                    return this.pathField;
                }
                set
                {
                    this.pathField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        [XmlRoot(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
        public partial class UnfiledNotes
        {

            private Section sectionField;

            private bool isCurrentlyViewedField;

            private string idField;

            public UnfiledNotes()
            {
                this.isCurrentlyViewedField = false;
            }

            /// <remarks/>
            public Section Section
            {
                get
                {
                    return this.sectionField;
                }
                set
                {
                    this.sectionField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isCurrentlyViewed
            {
                get
                {
                    return this.isCurrentlyViewedField;
                }
                set
                {
                    this.isCurrentlyViewedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string ID
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlType(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
        [XmlRoot(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
        public partial class OpenSections
        {

            private Section[] sectionField;

            private bool isCurrentlyViewedField;

            private string idField;

            public OpenSections()
            {
                this.isCurrentlyViewedField = false;
            }

            /// <remarks/>
            [XmlElement("Section")]
            public Section[] Section
            {
                get
                {
                    return this.sectionField;
                }
                set
                {
                    this.sectionField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool isCurrentlyViewed
            {
                get
                {
                    return this.isCurrentlyViewedField;
                }
                set
                {
                    this.isCurrentlyViewedField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string ID
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
    }
}
