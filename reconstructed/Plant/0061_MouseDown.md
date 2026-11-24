# System.Void MouseDown(System.Int32 x, System.Int32 y, System.Int32 theClickCount, System.Int32 playerIndex)

- 类：`Plant`
- 汇编行数：217

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rdi
	push r14
	sub rsp,20h
	cmp byte ptr [184EEB639h],0
	mov edi,r9d
	mov ebp,r8d
	mov r14d,edx
	mov rbx,rcx
	jne short 00000001806B3205h
	lea rcx,[184C7F440h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C73320h]
	call 00000001804FEB70h
	mov byte ptr [184EEB639h],1
	test edi,edi
	js near ptr 00000001806B3358h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806B336Eh
	mov rcx,[rax+0B8h]
	test rcx,rcx
	je near ptr 00000001806B336Eh
	mov r8,[184C73320h]
	mov edx,[rsp+50h]
	call 00000001809C0BC0h
	cmp dword ptr [rbx+88h],25h
	mov rdi,rax
	jne near ptr 00000001806B3358h
	test rax,rax
	je near ptr 00000001806B336Eh
	mov eax,[rax+7Ch]
	cmp eax,1
	je short 00000001806B327Eh
	cmp eax,2
	je short 00000001806B327Eh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B336Eh
	mov r8d,[rsp+50h]
	xor r9d,r9d
	xor edx,edx
	call 0000000180657E60h
	jmp short 00000001806B32CBh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B336Eh
	mov edx,[rsp+50h]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018066D8C0h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806B336Eh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B336Eh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,9
	call 0000000180002040h
	xor r8d,r8d
	mov dword ptr [rdi+74h],0FFFFFFFFh
	mov edx,8
	mov rcx,rdi
	call 000000018069CD70h
	xor ecx,ecx
	mov dword ptr [rdi+70h],0FFFFFFFFh
	call 000000018063CD70h
	mov [rdi+80h],eax
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806B336Eh
	mov rcx,[rcx+78h]
	test rcx,rcx
	je short 00000001806B336Eh
	mov r8,[184C7F440h]
	mov rdx,rbx
	call 00000001824484C0h
	xor edx,edx
	mov ecx,eax
	call 00000001806BE7D0h
	mov [rdi+8Ch],eax
	mov rax,[rbx+18h]
	test rax,rax
	je short 00000001806B336Eh
	mov dword ptr [rax+2A0h],1Eh
	mov rax,[rbx+18h]
	test rax,rax
	je short 00000001806B336Eh
	mov [rax+2A4h],r14d
	mov rax,[rbx+18h]
	test rax,rax
	je short 00000001806B336Eh
	mov [rax+2A8h],ebp
	mov rbx,[rsp+30h]
	mov rbp,[rsp+38h]
	mov rdi,[rsp+40h]
	add rsp,20h
	pop r14
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rdi
	004 ShiftStack -8
	005 Move stack:0x0, r14
	006 ShiftStack -32
	007 Compare [0x184EEB639], 0
	008 Move rdi, r9
	009 Move rbp, r8
	010 Move r14, rdx
	011 Move rbx, rcx
	012 JumpIfNotEqual {20}
	013 LoadAddress rcx, [0x184C7F440]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C75168]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C73320]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB639], 1
	020 Compare rdi, 0
	021 JumpIfSign {100}
	022 Move rax, [rbx+24]
	023 Compare rax, 0
	024 JumpIfEqual {107}
	025 Move rcx, [rax+184]
	026 Compare rcx, 0
	027 JumpIfEqual {107}
	028 Move r8, [0x184C73320]
	029 Move rdx, stack:0x50
	030 Call 0x1809C0BC0, rcx, rdx
	031 Compare [rbx+136], 37
	032 Move rdi, rax
	033 JumpIfNotEqual {100}
	034 Compare rax, 0
	035 JumpIfEqual {107}
	036 Move rax, [rax+124]
	037 Compare rax, 1
	038 JumpIfEqual {49}
	039 Compare rax, 2
	040 JumpIfEqual {49}
	041 Move rcx, [rbx+24]
	042 Compare rcx, 0
	043 JumpIfEqual {107}
	044 Move r8, stack:0x50
	045 Move r9, 0
	046 Move rdx, 0
	047 Call Board.ClearCursor, rcx, rdx, r8
	048 Goto {66}
	049 Move rcx, [rbx+24]
	050 Compare rcx, 0
	051 JumpIfEqual {107}
	052 Move rdx, stack:0x50
	053 Move r9, 0
	054 Move r8, 0
	055 Call Board.RefreshSeedPacketFromCursor, rcx, rdx, r8
	056 Move r8, [rbx+16]
	057 Compare r8, 0
	058 JumpIfEqual {107}
	059 Move r8, [r8+88]
	060 Compare r8, 0
	061 JumpIfEqual {107}
	062 Move rdx, typeof(Reloaded.Services.IAudioService)
	063 Move rcx, 6
	064 Move r9, 9
	065 Call 0x180002040, rcx, rdx, r8, r9
	066 Move r8, 0
	067 Move [rdi+116], 0xFFFFFFFF
	068 Move rdx, 8
	069 Move rcx, rdi
	070 Call CursorObject.set_CursorType, rcx, rdx
	071 Move rcx, 0
	072 Move [rdi+112], 0xFFFFFFFF
	073 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	074 Move [rdi+128], rax
	075 Move rcx, [rbx+24]
	076 Compare rcx, 0
	077 JumpIfEqual {107}
	078 Move rcx, [rcx+120]
	079 Compare rcx, 0
	080 JumpIfEqual {107}
	081 Move r8, [0x184C7F440]
	082 Move rdx, rbx
	083 Call 0x1824484C0, rcx, rdx
	084 Move rdx, 0
	085 Move rcx, rax
	086 Call 0x1806BE7D0, rcx, rdx
	087 Move [rdi+140], rax
	088 Move rax, [rbx+24]
	089 Compare rax, 0
	090 JumpIfEqual {107}
	091 Move [rax+672], 30
	092 Move rax, [rbx+24]
	093 Compare rax, 0
	094 JumpIfEqual {107}
	095 Move [rax+676], r14
	096 Move rax, [rbx+24]
	097 Compare rax, 0
	098 JumpIfEqual {107}
	099 Move [rax+680], rbp
	100 Move rbx, stack:0x30
	101 Move rbp, stack:0x38
	102 Move rdi, stack:0x40
	103 ShiftStack 32
	104 Move r14, stack:0x0
	105 ShiftStack 8
	106 Return 
	107 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
