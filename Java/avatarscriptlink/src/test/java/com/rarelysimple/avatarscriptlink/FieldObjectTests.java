package com.rarelysimple.avatarscriptlink;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertTrue;

import com.rarelysimple.avatarscriptlink.objects.FieldObject;

import org.junit.Before;
import org.junit.Test;

public class FieldObjectTests {
    
    private FieldObject newFieldObject;

    @Before
    public void setup() {
        newFieldObject = new FieldObject();
    }

    @Test
    public void fieldObject_enabled_canGetAndSet() {
        String expected = "1";
        newFieldObject.setEnabled(expected);
        String actual = newFieldObject.getEnabled();
        assertEquals(expected, actual);
    }

    @Test
    public void fieldObject_fieldNumber_canGetAndSet() {
        String expected = "12345.01";
        newFieldObject.setFieldNumber(expected);
        String actual = newFieldObject.getFieldNumber();
        assertEquals(expected, actual);
    }

    @Test
    public void fieldObject_fieldValue_canGetAndSet() {
        String expected = "field value";
        newFieldObject.setFieldValue(expected);
        String actual = newFieldObject.getFieldValue();
        assertEquals(expected, actual);
    }

    @Test
    public void fieldObject_lock_canGetAndSet() {
        String expected = "1";
        newFieldObject.setLock(expected);
        String actual = newFieldObject.getLock();
        assertEquals(expected, actual);
    }

    @Test
    public void fieldObject_required_canGetAndSet() {
        String expected = "1";
        newFieldObject.setRequired(expected);
        String actual = newFieldObject.getRequired();
        assertEquals(expected, actual);
    }

    @Test
    public void fieldObject_areEqual() {
        FieldObject fieldObject01 = new FieldObject("123", "TEST", true, false, false);
        FieldObject fieldObject02 = new FieldObject("123", "TEST", true, false, false);
        assertTrue(fieldObject01.equals(fieldObject02));
    }

    @Test
    public void fieldObject_areNotEqual() {
        FieldObject fieldObject01 = new FieldObject("123", "TEST", true, false, false);
        FieldObject fieldObject02 = new FieldObject("123", "TEST DIFFERENT", true, false, false);
        assertFalse(fieldObject01.equals(fieldObject02));
    }

    @Test
    public void fieldObject_isEnabled_IsFalse() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        assertFalse(fieldObject.isEnabled());
    }

    @Test
    public void fieldObject_isEnabled_IsTrue() {
        FieldObject fieldObject = new FieldObject("123", "TEST", true, false, false);
        assertTrue(fieldObject.isEnabled());
    }

    @Test
    public void fieldObject_isLocked_IsFalse() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        assertFalse(fieldObject.isLocked());
    }

    @Test
    public void fieldObject_isLocked_IsTrue() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, true, false);
        assertTrue(fieldObject.isLocked());
    }

    @Test
    public void fieldObject_isModified_0Parameter_IsFalse() {
        FieldObject fieldObject = new FieldObject();
        assertFalse(fieldObject.isModified());
    }

    @Test
    public void fieldObject_isModified_1Parameter_IsFalse() {
        FieldObject fieldObject = new FieldObject("123");
        assertFalse(fieldObject.isModified());
    }

    @Test
    public void fieldObject_isModified_2Parameter_IsFalse() {
        FieldObject fieldObject = new FieldObject("123", "TEST");
        assertFalse(fieldObject.isModified());
    }

    @Test
    public void fieldObject_isModified_5Parameter_IsFalse() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        assertFalse(fieldObject.isModified());
    }

    @Test
    public void fieldObject_isModified_IsTrue() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, true, false);
        fieldObject.setFieldValue("TEST MODIFIED");
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_isRequired_IsFalse() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        assertFalse(fieldObject.isRequired());
    }

    @Test
    public void fieldObject_isRequired_IsTrue() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, true);
        assertTrue(fieldObject.isRequired());
    }

    @Test
    public void fieldObject_setAsDisabled_areEqual() {
        FieldObject fieldObject = new FieldObject("123", "TEST", true, false, false);
        fieldObject.setAsDisabled();
        assertEquals("0", fieldObject.getEnabled());
        assertEquals("0", fieldObject.getRequired());
        assertFalse(fieldObject.isEnabled());
        assertFalse(fieldObject.isRequired());
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_setAsEnabled_areEqual() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        fieldObject.setAsEnabled();
        assertEquals("1", fieldObject.getEnabled());
        assertTrue(fieldObject.isEnabled());
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_setAsLocked_areEqual() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        fieldObject.setAsLocked();
        assertEquals("1", fieldObject.getLock());
        assertTrue(fieldObject.isLocked());
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_setAsModified_areEqual() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        fieldObject.setAsModified();
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_setAsOptional_areEqual() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        fieldObject.setAsOptional();
        assertEquals("1", fieldObject.getEnabled());
        assertEquals("0", fieldObject.getRequired());
        assertTrue(fieldObject.isEnabled());
        assertFalse(fieldObject.isRequired());
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_setAsRequired_areEqual() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        fieldObject.setAsRequired();
        assertEquals("1", fieldObject.getEnabled());
        assertEquals("1", fieldObject.getRequired());
        assertTrue(fieldObject.isEnabled());
        assertTrue(fieldObject.isRequired());
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_setAsUnlocked_areEqual() {
        FieldObject fieldObject = new FieldObject("123", "TEST", false, false, false);
        fieldObject.setAsUnlocked();
        assertEquals("0", fieldObject.getLock());
        assertFalse(fieldObject.isLocked());
        assertTrue(fieldObject.isModified());
    }

    @Test
    public void fieldObject_toHtmlString_withoutHtmlHeaders_NotNull() throws IllegalAccessException {
        String actual = new FieldObject("123").toHtmlString(false);
        assertNotNull(actual);
    }

    @Test
    public void fieldObject_toHtmlString_withHtmlHeaders_NotNull() throws IllegalAccessException {
        String actual = new FieldObject("123").toHtmlString(true);
        assertNotNull(actual);
    }

    @Test
    public void fieldObject_constructor_1Parameter_noError() {
        String fieldNumber = "123.45";
        FieldObject fieldObject = new FieldObject(fieldNumber);
        assertEquals(fieldNumber, fieldObject.getFieldNumber());
        assertEquals("", fieldObject.getFieldValue());
        assertFalse(fieldObject.isEnabled());
        assertFalse(fieldObject.isLocked());
        assertFalse(fieldObject.isRequired());
    }

    @Test(expected = IllegalArgumentException.class)
    public void fieldObject_constructor_1Parameter_error() {
        String fieldNumber = "";
        FieldObject fieldObject = new FieldObject(fieldNumber);
        assertEquals(fieldNumber, fieldObject.getFieldNumber());
        assertEquals("", fieldObject.getFieldValue());
        assertFalse(fieldObject.isEnabled());
        assertFalse(fieldObject.isLocked());
        assertFalse(fieldObject.isRequired());
    }

    @Test
    public void fieldObject_constructor_2Parameter_noError() {
        String fieldNumber = "123.45";
        String fieldValue = "TEST";
        FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue);
        assertEquals(fieldNumber, fieldObject.getFieldNumber());
        assertEquals(fieldValue, fieldObject.getFieldValue());
        assertFalse(fieldObject.isEnabled());
        assertFalse(fieldObject.isLocked());
        assertFalse(fieldObject.isRequired());
    }

    @Test(expected = IllegalArgumentException.class)
    public void fieldObject_constructor_2Parameter_error() {
        String fieldNumber = "";
        String fieldValue = "TEST";
        FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue);
        assertEquals(fieldNumber, fieldObject.getFieldNumber());
        assertEquals(fieldValue, fieldObject.getFieldValue());
        assertFalse(fieldObject.isEnabled());
        assertFalse(fieldObject.isLocked());
        assertFalse(fieldObject.isRequired());
    }

    @Test
    public void fieldObject_constructor_5Parameter_noError() {
        String fieldNumber = "123.45";
        String fieldValue = "TEST";
        FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue, false, false, false);
        assertEquals(fieldNumber, fieldObject.getFieldNumber());
        assertEquals(fieldValue, fieldObject.getFieldValue());
        assertFalse(fieldObject.isEnabled());
        assertFalse(fieldObject.isLocked());
        assertFalse(fieldObject.isRequired());
    }

    @Test(expected = IllegalArgumentException.class)
    public void fieldObject_constructor_5Parameter_error() {
        String fieldNumber = "";
        String fieldValue = "TEST";
        FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue, false, false, false);
        assertEquals(fieldNumber, fieldObject.getFieldNumber());
        assertEquals(fieldValue, fieldObject.getFieldValue());
        assertFalse(fieldObject.isEnabled());
        assertFalse(fieldObject.isLocked());
        assertFalse(fieldObject.isRequired());
    }

    @Test
    public void fieldObject_clone_areEqual() throws CloneNotSupportedException {
        FieldObject fieldObject01 = new FieldObject("123", "TEST", true, false, false);
        FieldObject fieldObject02 = fieldObject01.clone();
        assertTrue(fieldObject01.equals(fieldObject02));
    }

    @Test
    public void fieldObject_clone_areNotEqual() throws CloneNotSupportedException {
        FieldObject fieldObject01 = new FieldObject("123", "TEST", true, false, false);
        FieldObject fieldObject02 = fieldObject01.clone();
        fieldObject02.setFieldValue("Modified");
        assertFalse(fieldObject01.equals(fieldObject02));
    }
}