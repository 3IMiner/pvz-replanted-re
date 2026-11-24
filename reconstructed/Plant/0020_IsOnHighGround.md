# System.Boolean IsOnHighGround()

- 类：`Plant`
- 汇编行数：61

## 反汇编

```asm

Disassembly:
	sub rsp,28h
	cmp qword ptr [rcx+18h],0
	je short 00000001806B22DCh
	mov rax,[rcx+18h]
	mov rdx,[rax+120h]
	test rdx,rdx
	je short 00000001806B22E9h
	mov rax,[rdx+10h]
	movsxd r10,dword ptr [rcx+74h]
	movsxd r8,dword ptr [rcx+34h]
	cmp r10d,[rax]
	jae short 00000001806B22E3h
	mov r9,[rax+10h]
	cmp r8d,r9d
	jae short 00000001806B22E3h
	mov rcx,r10
	imul rcx,r9
	add rcx,r8
	cmp dword ptr [rdx+rcx*4+20h],4
	sete al
	add rsp,28h
	ret
	xor al,al
	add rsp,28h
	ret
	call 00000001804FEE10h
	int 3
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -40
	002 Compare [rcx+24], 0
	003 JumpIfEqual {23}
	004 Move rax, [rcx+24]
	005 Move rdx, [rax+288]
	006 Compare rdx, 0
	007 JumpIfEqual {28}
	008 Move rax, [rdx+16]
	009 Move r10, [rcx+116]
	010 Move r8, [rcx+52]
	011 Compare r10, [rax]
	012 JumpIfGreaterOrEqual {26}
	013 Move r9, [rax+16]
	014 Compare r8, r9
	015 JumpIfGreaterOrEqual {26}
	016 Move rcx, r10
	017 Multiply rcx, rcx, r9
	018 Add rcx, rcx, r8
	019 Compare [rdx+32+rcx*4], 4
	020 NotImplemented "sete al"
	021 ShiftStack 40
	022 Return rax
	023 Move rax, 0
	024 ShiftStack 40
	025 Return rax
	026 Call 0x1804FEE10, rcx, rdx, r8, r9
	027 Interrupt 
	028 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
