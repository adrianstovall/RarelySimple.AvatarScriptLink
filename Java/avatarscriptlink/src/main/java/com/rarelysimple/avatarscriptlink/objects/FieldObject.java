package com.rarelysimple.avatarscriptlink.objects;

import com.rarelysimple.avatarscriptlink.objects.advanced.abstracts.FieldObjectBase;

public class FieldObject extends FieldObjectBase {
    
    private static final long serialVersionUID = 1L;

    public FieldObject() {
        super();
    }

    public FieldObject(String fieldNumber) { 
        super(fieldNumber); 
    }

    public FieldObject(String fieldNumber, String fieldValue) { 
        super(fieldNumber, fieldValue); 
    }

    public FieldObject(String fieldNumber, String fieldValue, Boolean enabled, Boolean locked, Boolean required) {
        super(fieldNumber, fieldValue, enabled, locked, required); 
    }

    @Override
    public FieldObject clone() throws CloneNotSupportedException {
        return (FieldObject) super.clone();
    }
}