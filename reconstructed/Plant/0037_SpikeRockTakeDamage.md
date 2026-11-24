# System.Void SpikeRockTakeDamage()

- 类：`Plant`
- 汇编行数：123

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp byte ptr [184EEB678h],0
	mov rbx,rcx
	jne short 00000001806B5ACDh
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184CACAC8h]
	call 00000001804FEB70h
	lea rcx,[184CACB98h]
	call 00000001804FEB70h
	mov byte ptr [184EEB678h],1
	xor edx,edx
	mov rcx,rbx
	call 00000001806B5B90h
	mov eax,[rbx+8Ch]
	add eax,0FFFFFFCEh
	mov [rbx+8Ch],eax
	cmp eax,12Ch
	jg short 00000001806B5B12h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B5B86h
	mov rdx,[184CACB98h]
	xor r9d,r9d
	mov r8d,0FFFFFFFFh
	call 00000001807C8F00h
	cmp dword ptr [rbx+8Ch],96h
	jg short 00000001806B5B3Fh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B5B86h
	mov rdx,[184CACAC8h]
	xor r9d,r9d
	mov r8d,0FFFFFFFFh
	call 00000001807C8F00h
	cmp dword ptr [rbx+8Ch],0
	jg short 00000001806B5B80h
	mov rax,[rbx+10h]
	test rax,rax
	je short 00000001806B5B86h
	mov r8,[rax+58h]
	test r8,r8
	je short 00000001806B5B86h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,15h
	call 0000000180002040h
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
	004 Compare [0x184EEB678], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {14}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184CACAC8]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184CACB98]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 Move [0x184EEB678], 1
	014 Move rdx, 0
	015 Move rcx, rbx
	016 Call Plant.SpikeweedAttack, rcx, rdx
	017 Move rax, [rbx+140]
	018 Add rax, rax, 18446744073709551566
	019 Move [rbx+140], rax
	020 Compare rax, 300
	021 JumpIfGreater {29}
	022 Move rcx, [rbx+320]
	023 Compare rcx, 0
	024 JumpIfEqual {61}
	025 Move rdx, "bigspike3"
	026 Move r9, 0
	027 Move r8, 0xFFFFFFFF
	028 Call ReloadedController.AssignRenderGroupToTrack, rcx, rdx, r8
	029 Compare [rbx+140], 150
	030 JumpIfGreater {38}
	031 Move rcx, [rbx+320]
	032 Compare rcx, 0
	033 JumpIfEqual {61}
	034 Move rdx, "bigspike2"
	035 Move r9, 0
	036 Move r8, 0xFFFFFFFF
	037 Call ReloadedController.AssignRenderGroupToTrack, rcx, rdx, r8
	038 Compare [rbx+140], 0
	039 JumpIfGreater {57}
	040 Move rax, [rbx+16]
	041 Compare rax, 0
	042 JumpIfEqual {61}
	043 Move r8, [rax+88]
	044 Compare r8, 0
	045 JumpIfEqual {61}
	046 Move rdx, typeof(Reloaded.Services.IAudioService)
	047 Move rcx, 6
	048 Move r9, 21
	049 Call 0x180002040, rcx, rdx, r8, r9
	050 Move rdx, 0
	051 Move rcx, rbx
	052 ShiftStack 32
	053 Move rbx, stack:0x0
	054 ShiftStack 8
	055 Call Plant.Die, rcx, rdx
	056 Return 
	057 ShiftStack 32
	058 Move rbx, stack:0x0
	059 ShiftStack 8
	060 Return 
	061 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
