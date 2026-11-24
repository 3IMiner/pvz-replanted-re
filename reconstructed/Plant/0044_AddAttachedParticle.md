# Reloaded.Gameplay.TodParticleSystem AddAttachedParticle(System.Int32 thePosX, System.Int32 thePosY, System.Int32 theRenderPostition, Reloaded.Gameplay.ParticleEffect theEffect)

- 类：`Plant`
- 汇编行数：147

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	mov [rsp+20h],rdi
	push r14
	sub rsp,30h
	cmp byte ptr [184EEB64Fh],0
	mov esi,r9d
	mov ebp,r8d
	mov r14d,edx
	mov rbx,rcx
	jne short 00000001806AB152h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Fh],1
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AB16Bh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	jne short 00000001806AB199h
	xor eax,eax
	mov rbx,[rsp+40h]
	mov rbp,[rsp+48h]
	mov rsi,[rsp+50h]
	mov rdi,[rsp+58h]
	add rsp,30h
	pop r14
	ret
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806AB21Ah
	mov edx,[rbx+0D8h]
	xor r8d,r8d
	call 00000001807E1000h
	test rax,rax
	je short 00000001806AB1BFh
	xor edx,edx
	mov rcx,rax
	call 00000001806D7CD0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806AB21Ah
	mov eax,[rsp+60h]
	mov r9d,esi
	movd xmm2,ebp
	movd xmm1,r14d
	cvtdq2ps xmm2,xmm2
	mov qword ptr [rsp+28h],0
	mov [rsp+20h],eax
	cvtdq2ps xmm1,xmm1
	call 00000001807D9B50h
	mov rdi,rax
	test rax,rax
	je short 00000001806AB212h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806AB21Ah
	xor r8d,r8d
	mov rdx,rax
	call 00000001807E0FA0h
	mov [rbx+0D8h],eax
	mov rax,rdi
	jmp near ptr 00000001806AB17Eh
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rsi
	004 Move stack:0x20, rdi
	005 ShiftStack -8
	006 Move stack:0x0, r14
	007 ShiftStack -48
	008 Compare [0x184EEB64F], 0
	009 Move rsi, r9
	010 Move rbp, r8
	011 Move r14, rdx
	012 Move rbx, rcx
	013 JumpIfNotEqual {17}
	014 LoadAddress rcx, [0x184C2D478]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 Move [0x184EEB64F], 1
	017 Move rcx, typeof(UnityEngine.Object)
	018 Move rdi, [rbx+16]
	019 Compare [rcx+228], 0
	020 JumpIfNotEqual {22}
	021 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	022 Move r8, 0
	023 Move rdx, 0
	024 Move rcx, rdi
	025 Call Object.op_Inequality, rcx, rdx, r8
	026 Compare rax, 0
	027 JumpIfNotEqual {37}
	028 Move rax, 0
	029 Move rbx, stack:0x40
	030 Move rbp, stack:0x48
	031 Move rsi, stack:0x50
	032 Move rdi, stack:0x58
	033 ShiftStack 48
	034 Move r14, stack:0x0
	035 ShiftStack 8
	036 Return rax
	037 Move rcx, [rbx+16]
	038 Compare rcx, 0
	039 JumpIfEqual {72}
	040 Move rdx, [rbx+216]
	041 Move r8, 0
	042 Call GameplayActivity.ParticleTryToGet, rcx, rdx
	043 Compare rax, 0
	044 JumpIfEqual {48}
	045 Move rdx, 0
	046 Move rcx, rax
	047 Call TodParticleSystem.ParticleSystemDie, rcx, rdx
	048 Move rcx, [rbx+16]
	049 Compare rcx, 0
	050 JumpIfEqual {72}
	051 Move rax, stack:0x60
	052 Move r9, rsi
	053 Move xmm2, rbp
	054 Move xmm1, r14
	055 Move xmm2, xmm2
	056 Move stack:0x28, 0
	057 Move stack:0x20, rax
	058 Move xmm1, xmm1
	059 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	060 Move rdi, rax
	061 Compare rax, 0
	062 JumpIfEqual {70}
	063 Move rcx, [rbx+16]
	064 Compare rcx, 0
	065 JumpIfEqual {72}
	066 Move r8, 0
	067 Move rdx, rax
	068 Call GameplayActivity.ParticleGetID, rcx, rdx
	069 Move [rbx+216], rax
	070 Move rax, rdi
	071 Goto {29}
	072 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
