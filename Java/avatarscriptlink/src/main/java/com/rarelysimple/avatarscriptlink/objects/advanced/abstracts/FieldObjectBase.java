package com.rarelysimple.avatarscriptlink.objects.advanced.abstracts;

import java.io.Serializable;

import com.rarelysimple.avatarscriptlink.helpers.OptionObjectHelpers;
import com.rarelysimple.avatarscriptlink.objects.advanced.interfaces.IFieldObject;

public abstract class FieldObjectBase implements IFieldObject, Cloneable, Serializable {

    private static final long serialVersionUID = 1L;

    public String Enabled;
    public String FieldNumber;
    public String FieldValue;
    public String Lock;
    public String Required;

    private transient Boolean modified = false;

    private transient String originalEnabled;
    private transient String originalFieldNumber;
    private transient String originalFieldValue;
    private transient String originalLock;
    private transient String originalRequired;

    protected FieldObjectBase() {
        setEnabled("");
        setFieldNumber("");
        setFieldValue("");
        setLock("");
        setRequired("");
        setModified(false);
    }

    protected FieldObjectBase(String fieldNumber) {
        if (fieldNumber == null || fieldNumber.isEmpty())
            throw new IllegalArgumentException("parameterCannotBeNull");
        setEnabled("0");
        setFieldNumber(fieldNumber);
        setFieldValue("");
        setLock("0");
        setRequired("0");
        setModified(false);
    }

    protected FieldObjectBase(String fieldNumber, String fieldValue) {
        if (fieldNumber == null || fieldNumber.isEmpty())
            throw new IllegalArgumentException("parameterCannotBeNull");
        setEnabled("0");
        setFieldNumber(fieldNumber);
        setFieldValue(fieldValue);
        setLock("0");
        setRequired("0");
        setModified(false);
    }

    protected FieldObjectBase(String fieldNumber, String fieldValue, Boolean enabled, Boolean locked, Boolean required) {
        if (fieldNumber == null || fieldNumber.isEmpty())
            throw new IllegalArgumentException("parameterCannotBeNull");
        setEnabled(enabled ? "1" : "0");
        setFieldNumber(fieldNumber);
        setFieldValue(fieldValue);
        setLock(locked ? "1" : "0");
        setRequired(required ? "1" : "0");
        setModified(false);
    }

    public boolean equals(Object o) {
        if (o instanceof FieldObjectBase) {
            FieldObjectBase f = (FieldObjectBase) o;
            return Enabled == f.Enabled &&
                    FieldNumber == f.FieldNumber &&
                    FieldValue == f.FieldValue &&
                    Lock == f.Lock &&
                    Required == f.Required;
        }
        return false;
    }

    @Override
    public FieldObjectBase clone() throws CloneNotSupportedException {
        return (FieldObjectBase) super.clone();
    }

    public String getEnabled() {
        return Enabled;
    }

    public Boolean isEnabled() {
        return Enabled == "1";
    }

    public void setAsDisabled() {
        setEnabled("0");
        setRequired("0");
    }

    public void setAsEnabled() {
        setEnabled("1");
    }

    public void setEnabled(String value) {
        if (originalEnabled == null) 
            originalEnabled = value;
        modified = true;
        Enabled = value;
    }

    public String getFieldNumber() {
        return FieldNumber;
    }

    public void setFieldNumber(String value) {
        if (originalFieldNumber == null) 
            originalFieldNumber = value;
        else
            modified = true;
        FieldNumber = value;
    }

    public String getFieldValue() {
        return FieldValue;
    }

    public void setFieldValue(String value) {
        if (originalFieldValue == null) 
            originalFieldValue = value;
        else
            modified = true;
        FieldValue = value;
    }

    public String getLock() {
        return Lock;
    }

    public Boolean isLocked() {
        return Lock == "1";
    }

    public void setAsLocked() {
        setLock("1");
    }

    public void setAsUnlocked() {
        setLock("0");
    }

    public void setLock(String value) {
        if (originalLock == null) 
            originalLock = value;
        modified = true;
        Lock = value;
    }

    public Boolean isModified() {
        return modified;
    }

    public void setModified(boolean value) {
        modified = value;
    }

    public void setAsModified() {
        modified = true;
    }

    public void setAsUnmodified() {
        modified = false;
    }

    public String getRequired() {
        return Required;
    }

    public Boolean isRequired() {
        return Required == "1";
    }

    public void setAsOptional() {
        setEnabled("1");
        setRequired("0");
    }

    public void setAsRequired() {
        setEnabled("1");
        setRequired("1");
    }

    public void setRequired(String value) {
        if (originalRequired == null) 
            originalRequired = value;
        modified = true;
        Required = value;
    }

    public String toHtmlString() throws IllegalAccessException {
        return OptionObjectHelpers.transformToHtmlString(this);
    }

    public String toHtmlString(boolean includeHtmlHeaders) throws IllegalAccessException {
        return OptionObjectHelpers.transformToHtmlString(this, includeHtmlHeaders);
    }
}