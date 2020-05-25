package com.rarelysimple.avatarscriptlink.helpers;

import java.lang.reflect.Field;

import com.rarelysimple.avatarscriptlink.objects.advanced.interfaces.IFieldObject;

public class OptionObjectHelpers {
    
    public static String transformToHtmlString(IFieldObject fieldObject) throws IllegalAccessException {
        if (fieldObject == null)
            throw new IllegalArgumentException("parameterCannotBeNull");
        return transformToHtmlString(fieldObject, false);
    }
    
    public static String transformToHtmlString(IFieldObject fieldObject, boolean includeHtmlHeaders) throws IllegalAccessException {
        if (fieldObject == null) {
            throw new IllegalArgumentException("parameterCannotBeNull");
        }
        String html = "";
        html += includeHtmlHeaders ? getHtmlHeader() : "";
        html += getPageHeader(fieldObject.getClass().getSimpleName());
        html += getHtmlForObject(fieldObject, HtmlOutputType.Table);
        html += includeHtmlHeaders ? getHtmlFooter() : "";
        return html;
    }

    private static String getHtmlForObject(Object rawObject, HtmlOutputType htmlOutputType) throws IllegalAccessException {
        if (rawObject == null) { return ""; }
        String html = "";
        Field[] fields = getFieldInfo(rawObject);

        switch (htmlOutputType) {
            case TableHeaders:
                html += "<thead><tr>";
                break;
            case TableRow:
                html += "<tr>";
                break;
            case Table:
                html += "<table>" +
                        "<thead>" +
                        "<tr><th>Field</th><th>Value</th></tr>" +
                        "</thead>" +
                        "<tbody>";
                break;
            case OrderedList:
                html += "<ol>";
                break;
            case UnorderedList:
                html += "<ul>";
                break;
            default:
                break;
        }

        for (Field field : fields) {
            switch (htmlOutputType) {
                case TableHeaders:
                    html += "<th>" + field.getName() + "</th>";
                    break;
                case TableRow:
                    html += "<td>" + field.get(rawObject).toString() + "</td>";
                    break;
                case Table:
                    html += "<td>" + field.getName() + "</td><td>" + field.get(rawObject).toString() + "</td>";
                    break;
                case OrderedList:
                case UnorderedList:
                    html += "<li>" + field.getName() + "</td><td>" + field.get(rawObject).toString() + "</li>";
                    break;
                default:
                    break;
            }
        }

        switch (htmlOutputType)
        {
            case TableHeaders:
                html += "</tr></thead>";
                break;
            case TableRow:
                html += "</tr>";
                break;
            case Table:
                html += "</tbody>" +
                        "</table>";
                break;
            case OrderedList:
                html += "</ol>";
                break;
            case UnorderedList:
                html += "</ul>";
                break;
            default:
                break;
        }

        return html;
    }

    private static Field[] getFieldInfo(Object o) {
        return o.getClass().getFields();
    }

    private static String getHtmlHeader()
    {
        String html = "<html>" +
                      "<head>" +
                      "</head>" +
                      "<body>";
        return html;
    }
    private static String getPageHeader(String pageTitle)
    {
        String html = "<h1>" + pageTitle + "</h1>";
        return html;
    }
    private static String getHtmlFooter()
    {
        String html = "</body>" +
                      "</html>";
        return html;
    }

    private enum HtmlOutputType
    {
        None,
        Table,
        TableRow,
        TableHeaders,
        UnorderedList,
        OrderedList
    }
}