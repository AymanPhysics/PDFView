'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PDFView.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PageIndex&lt;/TITLE&gt;
        '''&lt;SCRIPT LANGUAGE=&quot;JavaScript&quot;&gt;
        '''function changeImage(filename)
        '''{
        '''  parent.pageviewer.document.images[&apos;mainimage&apos;].src = filename;
        '''}
        '''&lt;/script&gt;
        '''&lt;/HEAD&gt;
        '''&lt;BODY bgcolor=&quot;#DDDDDD&quot;&gt;{Body}&lt;/BODY&gt;
        '''&lt;/HTML&gt;.
        '''</summary>
        Friend ReadOnly Property BookmarkHtml() As String
            Get
                Return ResourceManager.GetString("BookmarkHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PDF to Image Html&lt;/TITLE&gt;
        '''&lt;/HEAD&gt;
        '''&lt;FRAMESET ROWS=&quot;50,*&quot; FRAMEBORDER=0 BORDER=0 &gt;
        '''                        &lt;FRAME NAME=&quot;top&quot; SRC=&quot;content/top.html&quot; MARGINHEIGHT=0 MARGINWIDTH=0 NORESIZE&gt;
        '''            &lt;FRAMESET COLS=&quot;20%,80%&quot; FRAMEBORDER=0 BORDER=0&gt;
        '''                        &lt;FRAME NAME=&quot;left&quot; SRC=&quot;content/bookmark.html&quot; MARGINHEIGHT=0 MARGINWIDTH=0 SCROLLING=AUTO NORESIZE&gt;
        '''                        &lt;FRAMESET ROWS=&quot;*,25&quot; FRAMEBORDER=0 BORDER=0 &gt;
        '''                        	&lt;FRAME NAME=&quot;pa [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property FrameHtml() As String
            Get
                Return ResourceManager.GetString("FrameHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PageViewer&lt;/TITLE&gt;
        '''&lt;/HEAD&gt;
        '''&lt;BODY bgcolor=&quot;#999999&quot;&gt;&lt;center&gt;&lt;img id=&quot;mainimage&quot; src=&quot;images/page1.png&quot; width=&quot;100%&quot;&gt;&lt;/center&gt;&lt;/BODY&gt;
        '''&lt;/HTML&gt;.
        '''</summary>
        Friend ReadOnly Property PageHtml() As String
            Get
                Return ResourceManager.GetString("PageHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PageSize&lt;/TITLE&gt;
        '''&lt;SCRIPT LANGUAGE=&quot;JavaScript&quot;&gt;
        '''function fitScreen()
        '''{
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.height = &apos;100%&apos;;
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.width = &apos;auto&apos;;
        '''}
        '''function fitWidth()
        '''{
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.height = &apos;auto&apos;;
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.width = &apos;100%&apos;;
        '''}
        '''function fitActual()
        '''{
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.height = &apos;auto&apos;;
        '''parent [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property PagesizeHtml() As String
            Get
                Return ResourceManager.GetString("PagesizeHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;DocumentName&lt;/TITLE&gt;
        '''&lt;/HEAD&gt;
        '''&lt;BODY bgcolor=&quot;#BBBBBB&quot;&gt;{DocumentName}&lt;/BODY&gt;
        '''&lt;/HTML&gt;.
        '''</summary>
        Friend ReadOnly Property TopHtml() As String
            Get
                Return ResourceManager.GetString("TopHtml", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
