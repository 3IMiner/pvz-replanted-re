# System.Void UpdateDoomShroom()

- 类：`Plant`
- 汇编行数：151

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB65Bh],0
	mov rbx,rcx
	jne short 00000001806B8EE5h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C8DF20h]
	call 00000001804FEB70h
	lea rcx,[184C70610h]
	call 00000001804FEB70h
	lea rcx,[184C8DD70h]
	call 00000001804FEB70h
	lea rcx,[184C8DE48h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Bh],1
	cmp byte ptr [rbx+136h],0
	jne near ptr 00000001806B8FF8h
	cmp dword ptr [rbx+88h],2
	je near ptr 00000001806B8FF8h
	mov [rsp+40h],rdi
	mov rcx,[rbx+140h]
	mov dword ptr [rbx+88h],2
	mov dword ptr [rbx+9Ch],64h
	test rcx,rcx
	je near ptr 00000001806B8FFEh
	movss xmm3,dword ptr [183C33EECh]
	xor edi,edi
	mov rdx,[184C70610h]
	xor r8d,r8d
	mov [rsp+28h],rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8FFEh
	movss xmm2,dword ptr [183C33C4Ch]
	xor r9d,r9d
	mov rdx,[184C8DD70h]
	mov [rsp+20h],rdi
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B8FFEh
	movss xmm2,dword ptr [183C33D94h]
	xor r9d,r9d
	mov rdx,[184C8DE48h]
	mov [rsp+20h],rdi
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B8FFEh
	movss xmm2,dword ptr [183C33D94h]
	xor r9d,r9d
	mov rdx,[184C8DF20h]
	mov [rsp+20h],rdi
	call 000000018060F880h
	mov r8,[rbx+10h]
	test r8,r8
	je short 00000001806B8FFEh
	mov r8,[r8+58h]
	test r8,r8
	je short 00000001806B8FFEh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,39h
	call 0000000180002040h
	mov rdi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB65B], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {18}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C8DF20]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C70610]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C8DD70]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C8DE48]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 Move [0x184EEB65B], 1
	018 Compare [rbx+310], 0
	019 JumpIfNotEqual {70}
	020 Compare [rbx+136], 2
	021 JumpIfEqual {70}
	022 Move stack:0x40, rdi
	023 Move rcx, [rbx+320]
	024 Move [rbx+136], 2
	025 Move [rbx+156], 100
	026 Compare rcx, 0
	027 JumpIfEqual {74}
	028 Move xmm3, [0x183C33EEC]
	029 Move rdi, 0
	030 Move rdx, "explode"
	031 Move r8, 0
	032 Move stack:0x28, rdi
	033 Move stack:0x20, 3
	034 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	035 Move rcx, [rbx+320]
	036 Compare rcx, 0
	037 JumpIfEqual {74}
	038 Move xmm2, [0x183C33C4C]
	039 Move r9, 0
	040 Move rdx, "DoomShroom_head1"
	041 Move stack:0x20, rdi
	042 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	043 Move rcx, [rbx+320]
	044 Compare rcx, 0
	045 JumpIfEqual {74}
	046 Move xmm2, typeof(T)
	047 Move r9, 0
	048 Move rdx, "DoomShroom_head2"
	049 Move stack:0x20, rdi
	050 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	051 Move rcx, [rbx+320]
	052 Compare rcx, 0
	053 JumpIfEqual {74}
	054 Move xmm2, typeof(T)
	055 Move r9, 0
	056 Move rdx, "DoomShroom_head3"
	057 Move stack:0x20, rdi
	058 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	059 Move r8, [rbx+16]
	060 Compare r8, 0
	061 JumpIfEqual {74}
	062 Move r8, [r8+88]
	063 Compare r8, 0
	064 JumpIfEqual {74}
	065 Move rdx, typeof(Reloaded.Services.IAudioService)
	066 Move rcx, 6
	067 Move r9, 57
	068 Call 0x180002040, rcx, rdx, r8, r9
	069 Move rdi, stack:0x40
	070 ShiftStack 48
	071 Move rbx, stack:0x0
	072 ShiftStack 8
	073 Return 
	074 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
