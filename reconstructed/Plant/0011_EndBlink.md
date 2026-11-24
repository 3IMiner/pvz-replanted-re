# System.Void EndBlink()

- 类：`Plant`
- 汇编行数：22

## 反汇编

```asm

Disassembly:
	sub rsp,28h
	mov rcx,[rcx+140h]
	test rcx,rcx
	je short 00000001806AF15Bh
	xor edx,edx
	add rsp,28h
	jmp near ptr 00000001807C7650h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -40
	002 Move rcx, [rcx+320]
	003 Compare rcx, 0
	004 JumpIfEqual {9}
	005 Move rdx, 0
	006 ShiftStack 40
	007 Call ReloadedCharacterController.DisableBlink, rcx, rdx
	008 Return 
	009 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
