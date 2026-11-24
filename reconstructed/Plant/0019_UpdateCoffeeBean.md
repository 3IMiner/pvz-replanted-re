# System.Void UpdateCoffeeBean()

- 类：`Plant`
- 汇编行数：53

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp dword ptr [rcx+88h],2
	mov rbx,rcx
	jne short 00000001806B8E7Bh
	mov rcx,[rcx+140h]
	test rcx,rcx
	je short 00000001806B8E81h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B8E7Bh
	xor edx,edx
	mov rcx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 00000001806ACD40h
	add rsp,20h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Compare [rcx+136], 2
	005 Move rbx, rcx
	006 JumpIfNotEqual {22}
	007 Move rcx, [rcx+320]
	008 Compare rcx, 0
	009 JumpIfEqual {26}
	010 Move r8, 0
	011 Move rdx, 0
	012 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	013 Compare rax, 0
	014 JumpIfLessOrEqual {22}
	015 Move rdx, 0
	016 Move rcx, rbx
	017 ShiftStack 32
	018 Move rbx, stack:0x0
	019 ShiftStack 8
	020 Call Plant.Die, rcx, rdx
	021 Return 
	022 ShiftStack 32
	023 Move rbx, stack:0x0
	024 ShiftStack 8
	025 Return 
	026 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
