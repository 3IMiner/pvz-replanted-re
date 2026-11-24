# System.Void PlantInitialize(System.Int32 theGridX, System.Int32 theGridY, Reloaded.Gameplay.SeedType theSeedType, Reloaded.Gameplay.SeedType theImitaterType, Source.Controllers.PlantController controller = null, System.Boolean forceDecemberContent = False, System.Boolean forceNormalContent = False)

- 类：`Plant`
- 汇编行数：2069

## 反汇编

```asm

Disassembly:
	mov [rsp+18h],rbx
	push rbp
	push rsi
	push rdi
	sub rsp,80h
	cmp byte ptr [184EEB635h],0
	mov esi,r8d
	movsxd rdi,r9d
	mov ebp,edx
	mov rbx,rcx
	jne near ptr 00000001806B39BAh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184CAC9F0h]
	call 00000001804FEB70h
	lea rcx,[184C905A8h]
	call 00000001804FEB70h
	lea rcx,[184C872F0h]
	call 00000001804FEB70h
	lea rcx,[184C9CFD8h]
	call 00000001804FEB70h
	lea rcx,[184C882B0h]
	call 00000001804FEB70h
	lea rcx,[184C88190h]
	call 00000001804FEB70h
	lea rcx,[184CAC778h]
	call 00000001804FEB70h
	lea rcx,[184C874A0h]
	call 00000001804FEB70h
	lea rcx,[184C70610h]
	call 00000001804FEB70h
	lea rcx,[184C59350h]
	call 00000001804FEB70h
	lea rcx,[184CAE4B0h]
	call 00000001804FEB70h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	lea rcx,[184CAF280h]
	call 00000001804FEB70h
	lea rcx,[184C87218h]
	call 00000001804FEB70h
	lea rcx,[184C687E8h]
	call 00000001804FEB70h
	lea rcx,[184C98670h]
	call 00000001804FEB70h
	lea rcx,[184C873C8h]
	call 00000001804FEB70h
	lea rcx,[184CA7B78h]
	call 00000001804FEB70h
	mov byte ptr [184EEB635h],1
	cmp qword ptr [rbx+18h],0
	mov [rsp+0A0h],r14
	mov [rsp+0A8h],r15
	movaps [rsp+70h],xmm6
	movaps [rsp+60h],xmm7
	movaps [rsp+50h],xmm8
	mov [rbx+74h],ebp
	mov [rbx+34h],esi
	je short 00000001806B3A2Ah
	mov rcx,[rbx+18h]
	xor r9d,r9d
	mov r8d,esi
	mov edx,ebp
	call 000000018065F590h
	mov rcx,[rbx+18h]
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rbx+20h],xmm0
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	mov r8d,esi
	mov edx,ebp
	call 000000018065F630h
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rbx+24h],xmm0
	xor r15d,r15d
	mov byte ptr [rbx+134h],1
	mov [rbx+78h],r15
	mov [rbx+0DCh],r15d
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3A54h
	call 00000001804FEEB0h
	xor r8d,r8d
	mov edx,12h
	mov ecx,0Ch
	call 00000001806CBDF0h
	mov [rbx+80h],eax
	xor ecx,ecx
	mov eax,[rsp+0C0h]
	mov [rbx+12Ch],eax
	mov eax,[rbx+34h]
	mov [rbx+0D4h],eax
	mov qword ptr [rbx+84h],5
	mov [rbx+135h],r15b
	mov [rbx+3Ch],r15b
	mov [rbx+70h],edi
	mov dword ptr [rbx+8Ch],12Ch
	mov qword ptr [rbx+98h],0C8h
	mov qword ptr [rbx+0CCh],0FFFFFFFFFFFFFFFFh
	mov [rbx+0A0h],r15d
	call 000000018063CD70h
	xor ecx,ecx
	mov [rbx+0D8h],eax
	call 000000018063CD70h
	xor ecx,ecx
	mov [rbx+0E0h],eax
	call 000000018063CD70h
	xor ecx,ecx
	mov [rbx+0E4h],eax
	call 000000018063CD70h
	xor ecx,ecx
	mov [rbx+0E8h],eax
	call 000000018063CD70h
	xor ecx,ecx
	mov [rbx+0ECh],eax
	call 000000018063CD70h
	xor ecx,ecx
	mov [rbx+0F0h],eax
	call 000000018063CD70h
	xor ecx,ecx
	mov [rbx+0F4h],eax
	call 000000018063CD70h
	xor edx,edx
	mov [rbx+0F8h],eax
	mov ecx,edi
	mov [rbx+0FCh],r15
	mov [rbx+104h],r15
	mov dword ptr [rbx+28h],50h
	mov dword ptr [rbx+2Ch],50h
	mov [rbx+10Ch],r15
	mov [rbx+136h],r15b
	mov [rbx+124h],r15
	mov dword ptr [rbx+130h],0FFFFFFFFh
	call 000000018077DF20h
	mov rbp,rax
	test rax,rax
	je near ptr 00000001806B4B6Eh
	mov ecx,[rax+60h]
	xor edx,edx
	mov [rbx+0A8h],ecx
	mov ecx,[rax+5Ch]
	mov [rbx+94h],ecx
	mov rcx,rbx
	call 00000001806AC2A0h
	mov rdx,[rsp+0C8h]
	lea rcx,[rbx+140h]
	mov [rbx+140h],rdx
	mov [rbx+38h],eax
	call 00000001804FDEA0h
	mov rcx,[184C2D478h]
	mov rsi,[rbx+140h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3BD0h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rsi
	call 0000000183832770h
	test al,al
	je short 00000001806B3C33h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	movzx eax,byte ptr [rsp+0D8h]
	mov r9b,1
	mov [rsp+38h],r15
	mov r8,rbx
	mov [rsp+30h],r15b
	mov edx,edi
	mov [rsp+28h],al
	movzx eax,byte ptr [rsp+0D0h]
	mov [rsp+20h],al
	call 00000001807DBAB0h
	lea rcx,[rbx+140h]
	mov [rbx+140h],rax
	mov rdx,rax
	call 00000001804FDEA0h
	mov rax,[rbx+118h]
	mov esi,r15d
	mov ecx,r15d
	test rax,rax
	je near ptr 00000001806B4B6Eh
	mov r14d,20h
	nop
	cmp ecx,[rax+18h]
	jge short 00000001806B3C9Ch
	mov rax,[rbx+118h]
	test rax,rax
	je near ptr 00000001806B4B6Eh
	cmp esi,[rax+18h]
	jae near ptr 00000001806B4B74h
	mov rcx,[r14+rax]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 00000001806C52A0h
	mov rax,[rbx+118h]
	inc esi
	add r14,8
	mov ecx,esi
	test rax,rax
	je near ptr 00000001806B4B6Eh
	jmp short 00000001806B3C50h
	cmp dword ptr [rbp+40h],0FFFFFFFFh
	movss xmm6,dword ptr [183C33DB8h]
	movss xmm7,dword ptr [183C33DACh]
	movss xmm8,dword ptr [183C33DB4h]
	je near ptr 00000001806B3E5Fh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C95FA8h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8940h
	test al,al
	je short 00000001806B3D38h
	cmp dword ptr [rbx+70h],33h
	je short 00000001806B3D38h
	mov rcx,[184C2AFC0h]
	mov rsi,[rbx+140h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3D07h
	call 00000001804FEEB0h
	xor r8d,r8d
	movaps xmm1,xmm6
	movaps xmm0,xmm7
	call 00000001806CBD40h
	test rsi,rsi
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C905A8h]
	movaps xmm3,xmm0
	xor r8d,r8d
	mov [rsp+20h],r15
	mov rcx,rsi
	call 00000001807C8210h
	mov rcx,[184C2D478h]
	mov rsi,[rbx+10h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3D51h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rsi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806B3E33h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 00000001807DFA20h
	test al,al
	je near ptr 00000001806B3E33h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C882B0h]
	movaps xmm3,xmm6
	mov [rsp+28h],r15
	xor r8d,r8d
	mov [rsp+20h],r15d
	call 00000001807C8270h
	cmp dword ptr [rbx+70h],3
	je short 00000001806B3DE9h
	cmp dword ptr [rbx+70h],31h
	je short 00000001806B3DE9h
	cmp dword ptr [rbx+70h],32h
	jne short 00000001806B3E33h
	mov rcx,[184C2AFC0h]
	mov rsi,[rbx+140h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3DDCh
	call 00000001804FEEB0h
	movss xmm0,dword ptr [183C33DA0h]
	movaps xmm1,xmm7
	jmp short 00000001806B3E11h
	mov rcx,[184C2AFC0h]
	mov rsi,[rbx+140h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3E05h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33EE4h]
	movaps xmm0,xmm8
	xor r8d,r8d
	call 00000001806CBD40h
	test rsi,rsi
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm0
	mov rcx,rsi
	call 00000001807C8740h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3E48h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,190h
	call 00000001806CBE80h
	add eax,190h
	mov [rbx+0FCh],eax
	mov eax,[rbx+70h]
	cmp eax,8
	je short 00000001806B3E7Bh
	cmp eax,1Fh
	ja short 00000001806B3E76h
	mov ecx,8100F600h
	bt ecx,eax
	jb short 00000001806B3E7Bh
	cmp eax,2Ah
	jne short 00000001806B3E9Dh
	cmp [rbx+18h],r15
	je short 00000001806B3E9Dh
	mov rcx,[rbx+18h]
	xor edx,edx
	call 0000000180671AF0h
	test al,al
	jne short 00000001806B3E9Dh
	xor r8d,r8d
	mov dl,1
	mov rcx,rbx
	call 00000001806B5700h
	cmp [rbx+0A8h],r15d
	jg short 00000001806B3EABh
	mov eax,r15d
	jmp short 00000001806B3F08h
	cmp dword ptr [rbx+70h],1
	je short 00000001806B3EDCh
	cmp dword ptr [rbx+70h],29h
	je short 00000001806B3EDCh
	cmp dword ptr [rbx+70h],9
	je short 00000001806B3EDCh
	mov rcx,[184C2AFC0h]
	mov esi,[rbx+0A8h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3ED8h
	call 00000001804FEEB0h
	xor ecx,ecx
	jmp short 00000001806B3EFEh
	mov rcx,[184C2AFC0h]
	mov esi,[rbx+0A8h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3EF7h
	call 00000001804FEEB0h
	shr esi,1
	mov ecx,12Ch
	xor r8d,r8d
	mov edx,esi
	call 00000001806CBDF0h
	mov [rbx+0A4h],eax
	cmp edi,1Bh
	je near ptr 00000001806B48FEh
	cmp edi,1
	jne near ptr 00000001806B3FAAh
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B3F39h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806B4A85h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B4B6Eh
	mov rcx,[rax+0C8h]
	test rcx,rcx
	je near ptr 00000001806B4A85h
	cmp [rcx+81h],r15b
	je near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C98670h]
	movaps xmm3,xmm8
	mov [rsp+28h],r15
	xor r8d,r8d
	mov [rsp+20h],r15d
	call 00000001807C8270h
	jmp near ptr 00000001806B4A85h
	cmp edi,34h
	ja short 00000001806B3FC3h
	mov rcx,100000000000A1h
	bt rcx,rdi
	jb near ptr 00000001806B488Eh
	cmp edi,28h
	je near ptr 00000001806B488Eh
	cmp edi,1Ch
	je near ptr 00000001806B47E7h
	cmp edi,12h
	je near ptr 00000001806B4725h
	cmp edi,3
	je near ptr 00000001806B46EAh
	cmp edi,31h
	je near ptr 00000001806B4682h
	cmp edi,32h
	je near ptr 00000001806B46EAh
	cmp edi,17h
	je near ptr 00000001806B466Fh
	cmp edi,24h
	je near ptr 00000001806B4660h
	cmp edi,2Dh
	je near ptr 00000001806B4A85h
	cmp edi,2
	je near ptr 00000001806B45E4h
	cmp edi,30h
	je near ptr 00000001806B4587h
	cmp edi,14h
	je near ptr 00000001806B45E4h
	cmp edi,4
	je near ptr 00000001806B451Ah
	cmp edi,0Bh
	je near ptr 00000001806B449Eh
	cmp edi,9
	je near ptr 00000001806B43DFh
	cmp edi,8
	je near ptr 00000001806B436Bh
	cmp edi,18h
	je near ptr 00000001806B436Bh
	cmp edi,1Eh
	je near ptr 00000001806B4355h
	cmp edi,6
	je near ptr 00000001806B4346h
	cmp edi,19h
	je near ptr 00000001806B4297h
	cmp edi,16h
	je near ptr 00000001806B4A85h
	cmp edi,26h
	je near ptr 00000001806B4249h
	cmp edi,1Ah
	je near ptr 00000001806B423Ah
	cmp edi,23h
	je near ptr 00000001806B422Bh
	cmp edi,0Dh
	je near ptr 00000001806B4346h
	cmp edi,2Fh
	je near ptr 00000001806B41DEh
	cmp edi,22h
	je near ptr 00000001806B41B4h
	cmp edi,1Fh
	je near ptr 00000001806B4A85h
	cmp edi,2Eh
	je near ptr 00000001806B41A5h
	cmp edi,33h
	je near ptr 00000001806B4A85h
	cmp edi,21h
	je short 00000001806B410Ah
	cmp edi,10h
	jne near ptr 00000001806B4A85h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je near ptr 00000001806B4A85h
	mov dword ptr [rbx+88h],30h
	mov dword ptr [rbx+0A0h],64h
	jmp near ptr 00000001806B4A85h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je short 00000001806B412Ch
	mov dword ptr [rbx+88h],2Fh
	mov dword ptr [rbx+0A0h],64h
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B4145h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806B4A85h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 00000001807E2DF0h
	test al,al
	je near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov r8,[rcx]
	mov rdx,[184C59350h]
	mov rax,[r8+1F8h]
	mov r8,[r8+200h]
	call rax
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+8Ch],1C2h
	jmp near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C687E8h]
	xor r9d,r9d
	mov r8d,0FFFFFFFFh
	call 00000001807C8DB0h
	jmp near ptr 00000001806B4A85h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	mov dword ptr [rbx+88h],23h
	mov dword ptr [rbx+0A0h],1F4h
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184CA7B78h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+9Ch],64h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+88h],1Eh
	jmp near ptr 00000001806B4A85h
	mov rcx,[184C2AFC0h]
	mov rdi,[rbx+140h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B4265h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DBCh]
	xor r8d,r8d
	movaps xmm0,xmm6
	call 00000001806CBD40h
	test rdi,rdi
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm0
	mov rcx,rdi
	call 00000001807C8740h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+0A0h],32h
	cmp [rbx+18h],r15
	je short 00000001806B42C9h
	cmp [rbx+137h],r15b
	je short 00000001806B42C9h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je short 00000001806B42FEh
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,7A121h
	movss xmm1,dword ptr [rbx+20h]
	mov rcx,rbx
	addss xmm2,dword ptr [183C33DC4h]
	addss xmm1,dword ptr [183C33DC4h]
	mov [rsp+28h],r15
	mov dword ptr [rsp+20h],2Eh
	call 00000001806AB220h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je near ptr 00000001806B4A85h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B4B6Eh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,6Bh
	call 0000000180002040h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+88h],1
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+8Ch],0FA0h
	mov dword ptr [rbx+28h],78h
	jmp near ptr 00000001806B4A85h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je near ptr 00000001806B4A85h
	mov rcx,[184C2AFC0h]
	movss xmm6,dword ptr [rbx+20h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B4397h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,0Ah
	call 00000001806CBE80h
	sub eax,5
	xor edx,edx
	mov ecx,6
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	addss xmm0,xmm6
	movss xmm6,dword ptr [rbx+24h]
	movss dword ptr [rbx+20h],xmm0
	call 00000001806CBE80h
	sub eax,3
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	addss xmm0,xmm6
	movss dword ptr [rbx+24h],xmm0
	jmp near ptr 00000001806B4A85h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	jne short 00000001806B4428h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	cmp [rbx+136h],r15b
	jne short 00000001806B441Ah
	mov rdx,[184CAC778h]
	call 00000001807C8230h
	jmp short 00000001806B4485h
	mov rdx,[184CAC9F0h]
	call 00000001807C8230h
	jmp short 00000001806B4485h
	mov rcx,[184C2AFC0h]
	movss xmm6,dword ptr [rbx+20h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B4442h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,0Ah
	call 00000001806CBE80h
	sub eax,5
	xor edx,edx
	mov ecx,0Ah
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	addss xmm0,xmm6
	movss xmm6,dword ptr [rbx+24h]
	movss dword ptr [rbx+20h],xmm0
	call 00000001806CBE80h
	sub eax,5
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	addss xmm0,xmm6
	movss dword ptr [rbx+24h],xmm0
	mov dword ptr [rbx+88h],17h
	mov dword ptr [rbx+0A0h],2EE0h
	jmp near ptr 00000001806B4A85h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184CAE4B0h]
	mov r9d,3
	xor r8d,r8d
	mov [rsp+20h],r15
	call 00000001807C81D0h
	mov r8,[rbx+10h]
	mov dword ptr [rbx+88h],8
	test r8,r8
	je near ptr 00000001806B4B6Eh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,36h
	call 0000000180002040h
	jmp near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm8
	call 00000001807C8740h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	jne short 00000001806B4578h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C9CFD8h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	mov dword ptr [rbx+88h],10h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+0A0h],5DCh
	jmp near ptr 00000001806B4A85h
	mov rcx,[184C2AFC0h]
	mov rdi,[rbx+140h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B45A3h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33C60h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DC0h]
	call 00000001806CBD40h
	test rdi,rdi
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm0
	mov rcx,rdi
	call 00000001807C8740h
	mov dword ptr [rbx+0A0h],0C8h
	jmp near ptr 00000001806B4A85h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	mov dword ptr [rbx+9Ch],64h
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C70610h]
	mov r9d,3
	xor r8d,r8d
	mov [rsp+20h],r15
	call 00000001807C81D0h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806B4B6Eh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,39h
	call 0000000180002040h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+8Ch],190h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+8Ch],1F40h
	mov dword ptr [rbx+2Ch],50h
	jmp short 00000001806B46F4h
	mov dword ptr [rbx+8Ch],0FA0h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B46A1h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,3E8h
	call 00000001806CBE80h
	mov rcx,[rbx+140h]
	add eax,3E8h
	mov [rbx+0FCh],eax
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	movdqa xmm0,[183C33F80h]
	lea rdx,[rsp+40h]
	xor r9d,r9d
	movaps [rsp+40h],xmm0
	xor r8d,r8d
	call 00000001807CAB40h
	jmp near ptr 00000001806B4A85h
	mov dword ptr [rbx+8Ch],0FA0h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B4709h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,3E8h
	call 00000001806CBE80h
	add eax,3E8h
	mov [rbx+0FCh],eax
	jmp near ptr 00000001806B4A85h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B473Ah
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DBCh]
	xor r8d,r8d
	movaps xmm0,xmm6
	call 00000001806CBD40h
	mov rcx,[rbx+140h]
	movaps xmm6,xmm0
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm0
	call 00000001807C8740h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C872F0h]
	movaps xmm3,xmm6
	mov r8d,2
	mov [rsp+20h],r15
	call 00000001807C8210h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C873C8h]
	movaps xmm3,xmm6
	mov r8d,3
	mov [rsp+20h],r15
	call 00000001807C8210h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C874A0h]
	movaps xmm3,xmm6
	mov r8d,4
	jmp near ptr 00000001806B4A7Bh
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B47FCh
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DBCh]
	xor r8d,r8d
	movaps xmm0,xmm6
	call 00000001806CBD40h
	mov rcx,[rbx+140h]
	movaps xmm6,xmm0
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm0
	call 00000001807C8740h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C87218h]
	movaps xmm3,xmm6
	mov r8d,2
	mov [rsp+20h],r15
	call 00000001807C8210h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C88190h]
	movaps xmm3,xmm6
	mov [rsp+28h],r15
	mov r8d,3
	mov [rsp+20h],r15d
	call 00000001807C8270h
	jmp near ptr 00000001806B4A85h
	mov rcx,[184C2D478h]
	mov rdi,[rbx+140h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B48AAh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806B4A85h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C87218h]
	movaps xmm3,xmm0
	mov r8d,2
	jmp near ptr 00000001806B4A7Bh
	mov dword ptr [rbx+9Ch],32h
	cmp [rbx+18h],r15
	je near ptr 00000001806B4A5Eh
	cmp [rbx+137h],r15b
	je near ptr 00000001806B4A5Eh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je near ptr 00000001806B4A5Eh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 00000001807E3010h
	cmp eax,32h
	je near ptr 00000001806B4A5Eh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	movss xmm6,dword ptr [183C33DBCh]
	xor r8d,r8d
	mov rdx,[184CAF280h]
	movaps xmm3,xmm6
	mov [rsp+28h],r15
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rdi,[rbx+10h]
	test rdi,rdi
	je near ptr 00000001806B4B6Eh
	mov rdi,[rdi+208h]
	test rdi,rdi
	je near ptr 00000001806B4B6Eh
	mov rcx,[184C2D478h]
	mov rdi,[rdi+0B0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B49C9h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806B4A85h
	test rdi,rdi
	je near ptr 00000001806B4B6Eh
	movss xmm0,dword ptr [183C33D58h]
	mov edx,0FFFFFFFFh
	movss xmm3,dword ptr [183C33C40h]
	mov r8d,2
	mov [rsp+30h],r15
	mov rcx,rdi
	mov [rsp+28h],r15b
	movss dword ptr [rsp+20h],xmm0
	call 00000001807ADD10h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rcx,[rcx+100h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 0000000180664F70h
	movaps xmm3,xmm6
	mov [rsp+28h],r15
	mov r8d,3
	movss dword ptr [rsp+20h],xmm7
	mov edx,eax
	mov rcx,rdi
	call 00000001807AD960h
	jmp short 00000001806B4A85h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	mov rdx,[184C905A8h]
	movaps xmm3,xmm7
	xor r8d,r8d
	mov [rsp+20h],r15
	call 00000001807C8210h
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806B4A9Eh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806B4AE8h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B4B6Eh
	xor edx,edx
	call 00000001807E3010h
	cmp eax,27h
	jne short 00000001806B4AE8h
	cmp dword ptr [rbx+70h],3
	je short 00000001806B4ADAh
	cmp dword ptr [rbx+70h],1
	je short 00000001806B4ADAh
	cmp dword ptr [rbx+70h],26h
	jne short 00000001806B4AE8h
	mov eax,[rbx+8Ch]
	add eax,eax
	mov [rbx+8Ch],eax
	cmp dword ptr [rbx+70h],21h
	mov eax,[rbx+8Ch]
	mov [rbx+90h],eax
	je short 00000001806B4B3Bh
	cmp [rbx+18h],r15
	je short 00000001806B4B3Bh
	cmp [rbx+137h],r15b
	je short 00000001806B4B3Bh
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	mov rcx,[rbx+18h]
	call 000000018065DE10h
	test rax,rax
	je short 00000001806B4B3Bh
	mov rcx,[rax+140h]
	test rcx,rcx
	je short 00000001806B4B6Eh
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	movaps xmm8,[rsp+50h]
	movaps xmm7,[rsp+60h]
	movaps xmm6,[rsp+70h]
	mov r15,[rsp+0A8h]
	mov r14,[rsp+0A0h]
	mov rbx,[rsp+0B0h]
	add rsp,80h
	pop rdi
	pop rsi
	pop rbp
	ret
	call 00000001804FEE20h
	int 3
	call 00000001804FEE10h

ISIL:
	001 Move stack:0x18, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rbp
	004 ShiftStack -8
	005 Move stack:0x0, rsi
	006 ShiftStack -8
	007 Move stack:0x0, rdi
	008 ShiftStack -128
	009 Compare [0x184EEB635], 0
	010 Move rsi, r8
	011 Move rdi, r9
	012 Move rbp, rdx
	013 Move rbx, rcx
	014 JumpIfNotEqual {58}
	015 LoadAddress rcx, [0x184C2AFC0]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C75168]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C2D478]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 LoadAddress rcx, [0x184CAC9F0]
	022 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	023 LoadAddress rcx, [0x184C905A8]
	024 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	025 LoadAddress rcx, [0x184C872F0]
	026 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	027 LoadAddress rcx, [0x184C9CFD8]
	028 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	029 LoadAddress rcx, [0x184C882B0]
	030 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	031 LoadAddress rcx, [0x184C88190]
	032 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	033 LoadAddress rcx, [0x184CAC778]
	034 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	035 LoadAddress rcx, [0x184C874A0]
	036 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	037 LoadAddress rcx, [0x184C70610]
	038 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	039 LoadAddress rcx, [0x184C59350]
	040 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	041 LoadAddress rcx, [0x184CAE4B0]
	042 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	043 LoadAddress rcx, [0x184C95FA8]
	044 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	045 LoadAddress rcx, [0x184CAF280]
	046 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	047 LoadAddress rcx, [0x184C87218]
	048 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	049 LoadAddress rcx, [0x184C687E8]
	050 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	051 LoadAddress rcx, [0x184C98670]
	052 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	053 LoadAddress rcx, [0x184C873C8]
	054 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	055 LoadAddress rcx, [0x184CA7B78]
	056 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	057 Move [0x184EEB635], 1
	058 Compare [rbx+24], 0
	059 Move stack:0xA0, r14
	060 Move stack:0xA8, r15
	061 Move stack:0x70, xmm6
	062 Move stack:0x60, xmm7
	063 Move stack:0x50, xmm8
	064 Move [rbx+116], rbp
	065 Move [rbx+52], rsi
	066 JumpIfEqual {85}
	067 Move rcx, [rbx+24]
	068 Move r9, 0
	069 Move r8, rsi
	070 Move rdx, rbp
	071 Call Board.GridToPixelX, rcx, rdx, r8
	072 Move rcx, [rbx+24]
	073 Move xmm0, rax
	074 Move xmm0, xmm0
	075 Move [rbx+32], xmm0
	076 Compare rcx, 0
	077 JumpIfEqual {1033}
	078 Move r9, 0
	079 Move r8, rsi
	080 Move rdx, rbp
	081 Call Board.GridToPixelY, rcx, rdx, r8
	082 Move xmm0, rax
	083 Move xmm0, xmm0
	084 Move [rbx+36], xmm0
	085 Move r15, 0
	086 Move [rbx+308], 1
	087 Move [rbx+120], r15
	088 Move [rbx+220], r15
	089 Move rcx, typeof(Reloaded.Gameplay.Common)
	090 Compare [rcx+228], r15
	091 JumpIfNotEqual {93}
	092 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	093 Move r8, 0
	094 Move rdx, 18
	095 Move rcx, 12
	096 Call Common.RandRangeInt, rcx, rdx, r8
	097 Move [rbx+128], rax
	098 Move rcx, 0
	099 Move rax, stack:0xC0
	100 Move [rbx+300], rax
	101 Move rax, [rbx+52]
	102 Move [rbx+212], rax
	103 Move [rbx+132], 5
	104 Move [rbx+309], r15
	105 Move [rbx+60], r15
	106 Move [rbx+112], rdi
	107 Move [rbx+140], 300
	108 Move [rbx+152], 200
	109 Move [rbx+204], 18446744073709551615
	110 Move [rbx+160], r15
	111 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	112 Move rcx, 0
	113 Move [rbx+216], rax
	114 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	115 Move rcx, 0
	116 Move [rbx+224], rax
	117 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	118 Move rcx, 0
	119 Move [rbx+228], rax
	120 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	121 Move rcx, 0
	122 Move [rbx+232], rax
	123 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	124 Move rcx, 0
	125 Move [rbx+236], rax
	126 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	127 Move rcx, 0
	128 Move [rbx+240], rax
	129 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	130 Move rcx, 0
	131 Move [rbx+244], rax
	132 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	133 Move rdx, 0
	134 Move [rbx+248], rax
	135 Move rcx, rdi
	136 Move [rbx+252], r15
	137 Move [rbx+260], r15
	138 Move [rbx+40], 80
	139 Move [rbx+44], 80
	140 Move [rbx+268], r15
	141 Move [rbx+310], r15
	142 Move [rbx+292], r15
	143 Move [rbx+304], 0xFFFFFFFF
	144 Call ReloadedUtils.GetPlantDefinition, rcx, rdx
	145 Move rbp, rax
	146 Compare rax, 0
	147 JumpIfEqual {1033}
	148 Move rcx, [rax+96]
	149 Move rdx, 0
	150 Move [rbx+168], rcx
	151 Move rcx, [rax+92]
	152 Move [rbx+148], rcx
	153 Move rcx, rbx
	154 Call Plant.CalcRenderOrder, rcx, rdx
	155 Move rdx, stack:0xC8
	156 LoadAddress rcx, [rbx+320]
	157 Move [rbx+320], rdx
	158 Move [rbx+56], rax
	159 Call 0x1804FDEA0, rcx, rdx, r8, r9
	160 Move rcx, typeof(UnityEngine.Object)
	161 Move rsi, [rbx+320]
	162 Compare [rcx+228], r15
	163 JumpIfNotEqual {165}
	164 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	165 Move r8, 0
	166 Move rdx, 0
	167 Move rcx, rsi
	168 Call Object.op_Equality, rcx, rdx, r8
	169 Compare rax, 0
	170 JumpIfEqual {188}
	171 Move rcx, [rbx+16]
	172 Compare rcx, 0
	173 JumpIfEqual {1033}
	174 Move rax, stack:0xD8
	175 Move r9, 1
	176 Move stack:0x38, r15
	177 Move r8, rbx
	178 Move stack:0x30, r15
	179 Move rdx, rdi
	180 Move stack:0x28, rax
	181 Move rax, stack:0xD0
	182 Move stack:0x20, rax
	183 Call GameplayActivity.CreatePlantController, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	184 LoadAddress rcx, [rbx+320]
	185 Move [rbx+320], rax
	186 Move rdx, rax
	187 Call 0x1804FDEA0, rcx, rdx, r8, r9
	188 Move rax, [rbx+280]
	189 Move rsi, r15
	190 Move rcx, r15
	191 Compare rax, 0
	192 JumpIfEqual {1033}
	193 Move r14, 32
	194 Nop 
	195 Compare rcx, [rax+24]
	196 JumpIfGreaterOrEqual {214}
	197 Move rax, [rbx+280]
	198 Compare rax, 0
	199 JumpIfEqual {1033}
	200 Compare rsi, [rax+24]
	201 JumpIfGreaterOrEqual {1035}
	202 Move rcx, [r14+rax]
	203 Compare rcx, 0
	204 JumpIfEqual {1033}
	205 Move rdx, 0
	206 Call MagnetItem.Reset, rcx, rdx
	207 Move rax, [rbx+280]
	208 Add rsi, rsi, 1
	209 Add r14, r14, 8
	210 Move rcx, rsi
	211 Compare rax, 0
	212 JumpIfEqual {1033}
	213 Goto {195}
	214 Compare [rbp+64], 18446744073709551615
	215 Move xmm6, [0x183C33DB8]
	216 Move xmm7, [0x183C33DAC]
	217 Move xmm8, [0x183C33DB4]
	218 JumpIfEqual {313}
	219 Move rcx, [rbx+320]
	220 Compare rcx, 0
	221 JumpIfEqual {1033}
	222 Move rdx, "anim_idle"
	223 Move r9, 0
	224 Move r8, 0
	225 Call ReloadedCharacterController.TrackExistsOnTrack, rcx, rdx, r8
	226 Compare rax, 0
	227 JumpIfEqual {247}
	228 Compare [rbx+112], 51
	229 JumpIfEqual {247}
	230 Move rcx, typeof(Reloaded.Gameplay.Common)
	231 Move rsi, [rbx+320]
	232 Compare [rcx+228], r15
	233 JumpIfNotEqual {235}
	234 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	235 Move r8, 0
	236 Move xmm1, xmm6
	237 Move xmm0, xmm7
	238 Call Common.RandRangeFloat, xmm0, xmm1, r8
	239 Compare rsi, 0
	240 JumpIfEqual {1033}
	241 Move rdx, "idle"
	242 Move xmm3, xmm0
	243 Move r8, 0
	244 Move stack:0x20, r15
	245 Move rcx, rsi
	246 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	247 Move rcx, typeof(UnityEngine.Object)
	248 Move rsi, [rbx+16]
	249 Compare [rcx+228], r15
	250 JumpIfNotEqual {252}
	251 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	252 Move r8, 0
	253 Move rdx, 0
	254 Move rcx, rsi
	255 Call Object.op_Inequality, rcx, rdx, r8
	256 Compare rax, 0
	257 JumpIfEqual {304}
	258 Move rcx, [rbx+16]
	259 Compare rcx, 0
	260 JumpIfEqual {1033}
	261 Move rdx, 0
	262 Call GameplayActivity.IsWallnutBowlingLevel, rcx, rdx
	263 Compare rax, 0
	264 JumpIfEqual {304}
	265 Move rcx, [rbx+320]
	266 Compare rcx, 0
	267 JumpIfEqual {1033}
	268 Move rdx, "_ground"
	269 Move xmm3, xmm6
	270 Move stack:0x28, r15
	271 Move r8, 0
	272 Move stack:0x20, r15
	273 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	274 Compare [rbx+112], 3
	275 JumpIfEqual {288}
	276 Compare [rbx+112], 49
	277 JumpIfEqual {288}
	278 Compare [rbx+112], 50
	279 JumpIfNotEqual {304}
	280 Move rcx, typeof(Reloaded.Gameplay.Common)
	281 Move rsi, [rbx+320]
	282 Compare [rcx+228], r15
	283 JumpIfNotEqual {285}
	284 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	285 Move xmm0, [0x183C33DA0]
	286 Move xmm1, xmm7
	287 Goto {295}
	288 Move rcx, typeof(Reloaded.Gameplay.Common)
	289 Move rsi, [rbx+320]
	290 Compare [rcx+228], r15
	291 JumpIfNotEqual {293}
	292 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	293 Move xmm1, [0x183C33EE4]
	294 Move xmm0, xmm8
	295 Move r8, 0
	296 Call Common.RandRangeFloat, xmm0, xmm1, r8
	297 Compare rsi, 0
	298 JumpIfEqual {1033}
	299 Move r9, 0
	300 Move r8, 0
	301 Move xmm1, xmm0
	302 Move rcx, rsi
	303 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	304 Move rcx, typeof(Reloaded.Gameplay.Common)
	305 Compare [rcx+228], r15
	306 JumpIfNotEqual {308}
	307 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	308 Move rdx, 0
	309 Move rcx, 400
	310 Call Common.Rand, rcx, rdx
	311 Add rax, rax, 400
	312 Move [rbx+252], rax
	313 Move rax, [rbx+112]
	314 Compare rax, 8
	315 JumpIfEqual {323}
	316 Compare rax, 31
	317 JumpIfGreater {321}
	318 Move rcx, 0x8100F600
	319 NotImplemented "bt ecx,eax"
	320 JumpIfLess {323}
	321 Compare rax, 42
	322 JumpIfNotEqual {334}
	323 Compare [rbx+24], r15
	324 JumpIfEqual {334}
	325 Move rcx, [rbx+24]
	326 Move rdx, 0
	327 Call Board.StageIsNight, rcx, rdx
	328 Compare rax, 0
	329 JumpIfNotEqual {334}
	330 Move r8, 0
	331 Move rdx, 1
	332 Move rcx, rbx
	333 Call Plant.SetSleeping, rcx, rdx
	334 Compare [rbx+168], r15
	335 JumpIfGreater {338}
	336 Move rax, r15
	337 Goto {361}
	338 Compare [rbx+112], 1
	339 JumpIfEqual {351}
	340 Compare [rbx+112], 41
	341 JumpIfEqual {351}
	342 Compare [rbx+112], 9
	343 JumpIfEqual {351}
	344 Move rcx, typeof(Reloaded.Gameplay.Common)
	345 Move rsi, [rbx+168]
	346 Compare [rcx+228], r15
	347 JumpIfNotEqual {349}
	348 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	349 Move rcx, 0
	350 Goto {358}
	351 Move rcx, typeof(Reloaded.Gameplay.Common)
	352 Move rsi, [rbx+168]
	353 Compare [rcx+228], r15
	354 JumpIfNotEqual {356}
	355 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	356 ShiftRight rsi, 1
	357 Move rcx, 300
	358 Move r8, 0
	359 Move rdx, rsi
	360 Call Common.RandRangeInt, rcx, rdx, r8
	361 Move [rbx+164], rax
	362 Compare rdi, 27
	363 JumpIfEqual {889}
	364 Compare rdi, 1
	365 JumpIfNotEqual {395}
	366 Move rcx, typeof(UnityEngine.Object)
	367 Move rdi, [rbx+16]
	368 Compare [rcx+228], r15
	369 JumpIfNotEqual {371}
	370 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	371 Move r8, 0
	372 Move rdx, 0
	373 Move rcx, rdi
	374 Call Object.op_Inequality, rcx, rdx, r8
	375 Compare rax, 0
	376 JumpIfEqual {970}
	377 Move rax, [rbx+16]
	378 Compare rax, 0
	379 JumpIfEqual {1033}
	380 Move rcx, [rax+200]
	381 Compare rcx, 0
	382 JumpIfEqual {970}
	383 Compare [rcx+129], r15
	384 JumpIfEqual {970}
	385 Move rcx, [rbx+320]
	386 Compare rcx, 0
	387 JumpIfEqual {1033}
	388 Move rdx, "anim_sleep"
	389 Move xmm3, xmm8
	390 Move stack:0x28, r15
	391 Move r8, 0
	392 Move stack:0x20, r15
	393 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	394 Goto {970}
	395 Compare rdi, 52
	396 JumpIfGreater {400}
	397 Move rcx, 0x100000000000A1
	398 NotImplemented "bt rcx,rdi"
	399 JumpIfLess {865}
	400 Compare rdi, 40
	401 JumpIfEqual {865}
	402 Compare rdi, 28
	403 JumpIfEqual {831}
	404 Compare rdi, 18
	405 JumpIfEqual {792}
	406 Compare rdi, 3
	407 JumpIfEqual {781}
	408 Compare rdi, 49
	409 JumpIfEqual {761}
	410 Compare rdi, 50
	411 JumpIfEqual {781}
	412 Compare rdi, 23
	413 JumpIfEqual {758}
	414 Compare rdi, 36
	415 JumpIfEqual {756}
	416 Compare rdi, 45
	417 JumpIfEqual {970}
	418 Compare rdi, 2
	419 JumpIfEqual {731}
	420 Compare rdi, 48
	421 JumpIfEqual {713}
	422 Compare rdi, 20
	423 JumpIfEqual {731}
	424 Compare rdi, 4
	425 JumpIfEqual {690}
	426 Compare rdi, 11
	427 JumpIfEqual {665}
	428 Compare rdi, 9
	429 JumpIfEqual {622}
	430 Compare rdi, 8
	431 JumpIfEqual {594}
	432 Compare rdi, 24
	433 JumpIfEqual {594}
	434 Compare rdi, 30
	435 JumpIfEqual {591}
	436 Compare rdi, 6
	437 JumpIfEqual {589}
	438 Compare rdi, 25
	439 JumpIfEqual {552}
	440 Compare rdi, 22
	441 JumpIfEqual {970}
	442 Compare rdi, 38
	443 JumpIfEqual {535}
	444 Compare rdi, 26
	445 JumpIfEqual {533}
	446 Compare rdi, 35
	447 JumpIfEqual {531}
	448 Compare rdi, 13
	449 JumpIfEqual {589}
	450 Compare rdi, 47
	451 JumpIfEqual {516}
	452 Compare rdi, 34
	453 JumpIfEqual {508}
	454 Compare rdi, 31
	455 JumpIfEqual {970}
	456 Compare rdi, 46
	457 JumpIfEqual {506}
	458 Compare rdi, 51
	459 JumpIfEqual {970}
	460 Compare rdi, 33
	461 JumpIfEqual {472}
	462 Compare rdi, 16
	463 JumpIfNotEqual {970}
	464 Move rdx, 0
	465 Move rcx, rbx
	466 Call Plant.IsInPlay, rcx, rdx
	467 Compare rax, 0
	468 JumpIfEqual {970}
	469 Move [rbx+136], 48
	470 Move [rbx+160], 100
	471 Goto {970}
	472 Move rdx, 0
	473 Move rcx, rbx
	474 Call Plant.IsInPlay, rcx, rdx
	475 Compare rax, 0
	476 JumpIfEqual {479}
	477 Move [rbx+136], 47
	478 Move [rbx+160], 100
	479 Move rcx, typeof(UnityEngine.Object)
	480 Move rdi, [rbx+16]
	481 Compare [rcx+228], r15
	482 JumpIfNotEqual {484}
	483 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	484 Move r8, 0
	485 Move rdx, 0
	486 Move rcx, rdi
	487 Call Object.op_Inequality, rcx, rdx, r8
	488 Compare rax, 0
	489 JumpIfEqual {970}
	490 Move rcx, [rbx+16]
	491 Compare rcx, 0
	492 JumpIfEqual {1033}
	493 Move rdx, 0
	494 Call GameplayActivity.get_ChinaMode, rcx, rdx
	495 Compare rax, 0
	496 JumpIfEqual {970}
	497 Move rcx, [rbx+320]
	498 Compare rcx, 0
	499 JumpIfEqual {1033}
	500 Move r8, [rcx]
	501 Move rdx, "China"
	502 Move rax, [r8+504]
	503 Move r8, [r8+512]
	504 Call rax
	505 Goto {970}
	506 Move [rbx+140], 450
	507 Goto {970}
	508 Move rcx, [rbx+320]
	509 Compare rcx, 0
	510 JumpIfEqual {1033}
	511 Move rdx, "Cornpult_butter"
	512 Move r9, 0
	513 Move r8, 0xFFFFFFFF
	514 Call ReloadedController.AssignRenderGroupToPrefix, rcx, rdx, r8
	515 Goto {970}
	516 Move rdx, 0
	517 Move rcx, rbx
	518 Call Plant.IsInPlay, rcx, rdx
	519 Compare rax, 0
	520 JumpIfEqual {970}
	521 Move rcx, [rbx+320]
	522 Move [rbx+136], 35
	523 Move [rbx+160], 500
	524 Compare rcx, 0
	525 JumpIfEqual {1033}
	526 Move rdx, "unarmed_idle"
	527 Move r9, 0
	528 Move r8, 0
	529 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	530 Goto {970}
	531 Move [rbx+156], 100
	532 Goto {970}
	533 Move [rbx+136], 30
	534 Goto {970}
	535 Move rcx, typeof(Reloaded.Gameplay.Common)
	536 Move rdi, [rbx+320]
	537 Compare [rcx+228], r15
	538 JumpIfNotEqual {540}
	539 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	540 Move xmm1, [0x183C33DBC]
	541 Move r8, 0
	542 Move xmm0, xmm6
	543 Call Common.RandRangeFloat, xmm0, xmm1, r8
	544 Compare rdi, 0
	545 JumpIfEqual {1033}
	546 Move r9, 0
	547 Move r8, 0
	548 Move xmm1, xmm0
	549 Move rcx, rdi
	550 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	551 Goto {970}
	552 Move [rbx+160], 50
	553 Compare [rbx+24], r15
	554 JumpIfEqual {564}
	555 Compare [rbx+311], r15
	556 JumpIfEqual {564}
	557 Move rcx, [rbx+16]
	558 Compare rcx, 0
	559 JumpIfEqual {1033}
	560 Move rdx, 0
	561 Call GameplayActivity.get_GameMode, rcx, rdx
	562 Compare rax, 43
	563 JumpIfEqual {573}
	564 Move xmm2, [rbx+36]
	565 Move r9, 0x7A121
	566 Move xmm1, [rbx+32]
	567 Move rcx, rbx
	568 Add xmm2, xmm2, [0x183C33DC4]
	569 Add xmm1, xmm1, [0x183C33DC4]
	570 Move stack:0x28, r15
	571 Move stack:0x20, 46
	572 Call Plant.AddAttachedParticle, rcx, xmm1, r8, r9, stack:0x0
	573 Move rdx, 0
	574 Move rcx, rbx
	575 Call Plant.IsInPlay, rcx, rdx
	576 Compare rax, 0
	577 JumpIfEqual {970}
	578 Move rax, [rbx+16]
	579 Compare rax, 0
	580 JumpIfEqual {1033}
	581 Move r8, [rax+88]
	582 Compare r8, 0
	583 JumpIfEqual {1033}
	584 Move rdx, typeof(Reloaded.Services.IAudioService)
	585 Move rcx, 25
	586 Move r9, 107
	587 Call 0x180002040, rcx, rdx, r8, r9
	588 Goto {970}
	589 Move [rbx+136], 1
	590 Goto {970}
	591 Move [rbx+140], 4000
	592 Move [rbx+40], 120
	593 Goto {970}
	594 Move rdx, 0
	595 Move rcx, rbx
	596 Call Plant.IsInPlay, rcx, rdx
	597 Compare rax, 0
	598 JumpIfEqual {970}
	599 Move rcx, typeof(Reloaded.Gameplay.Common)
	600 Move xmm6, [rbx+32]
	601 Compare [rcx+228], r15
	602 JumpIfNotEqual {604}
	603 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	604 Move rdx, 0
	605 Move rcx, 10
	606 Call Common.Rand, rcx, rdx
	607 Subtract rax, rax, 5
	608 Move rdx, 0
	609 Move rcx, 6
	610 Move xmm0, rax
	611 Move xmm0, xmm0
	612 Add xmm0, xmm0, xmm6
	613 Move xmm6, [rbx+36]
	614 Move [rbx+32], xmm0
	615 Call Common.Rand, rcx, rdx
	616 Subtract rax, rax, 3
	617 Move xmm0, rax
	618 Move xmm0, xmm0
	619 Add xmm0, xmm0, xmm6
	620 Move [rbx+36], xmm0
	621 Goto {970}
	622 Move rdx, 0
	623 Move rcx, rbx
	624 Call Plant.IsInPlay, rcx, rdx
	625 Compare rax, 0
	626 JumpIfNotEqual {640}
	627 Move rcx, [rbx+320]
	628 Compare rcx, 0
	629 JumpIfEqual {1033}
	630 Move r9, 0
	631 Move r8, 0
	632 Compare [rbx+310], r15
	633 JumpIfNotEqual {637}
	634 Move rdx, "bigIdle"
	635 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	636 Goto {662}
	637 Move rdx, "bigsleep"
	638 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	639 Goto {662}
	640 Move rcx, typeof(Reloaded.Gameplay.Common)
	641 Move xmm6, [rbx+32]
	642 Compare [rcx+228], r15
	643 JumpIfNotEqual {645}
	644 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	645 Move rdx, 0
	646 Move rcx, 10
	647 Call Common.Rand, rcx, rdx
	648 Subtract rax, rax, 5
	649 Move rdx, 0
	650 Move rcx, 10
	651 Move xmm0, rax
	652 Move xmm0, xmm0
	653 Add xmm0, xmm0, xmm6
	654 Move xmm6, [rbx+36]
	655 Move [rbx+32], xmm0
	656 Call Common.Rand, rcx, rdx
	657 Subtract rax, rax, 5
	658 Move xmm0, rax
	659 Move xmm0, xmm0
	660 Add xmm0, xmm0, xmm6
	661 Move [rbx+36], xmm0
	662 Move [rbx+136], 23
	663 Move [rbx+160], 0x2EE0
	664 Goto {970}
	665 Move rdx, 0
	666 Move rcx, rbx
	667 Call Plant.IsInPlay, rcx, rdx
	668 Compare rax, 0
	669 JumpIfEqual {970}
	670 Move rcx, [rbx+320]
	671 Compare rcx, 0
	672 JumpIfEqual {1033}
	673 Move rdx, "land"
	674 Move r9, 3
	675 Move r8, 0
	676 Move stack:0x20, r15
	677 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8, r9
	678 Move r8, [rbx+16]
	679 Move [rbx+136], 8
	680 Compare r8, 0
	681 JumpIfEqual {1033}
	682 Move r8, [r8+88]
	683 Compare r8, 0
	684 JumpIfEqual {1033}
	685 Move rdx, typeof(Reloaded.Services.IAudioService)
	686 Move rcx, 6
	687 Move r9, 54
	688 Call 0x180002040, rcx, rdx, r8, r9
	689 Goto {970}
	690 Move rcx, [rbx+320]
	691 Compare rcx, 0
	692 JumpIfEqual {1033}
	693 Move r9, 0
	694 Move r8, 0
	695 Move xmm1, xmm8
	696 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	697 Move rdx, 0
	698 Move rcx, rbx
	699 Call Plant.IsInPlay, rcx, rdx
	700 Compare rax, 0
	701 JumpIfNotEqual {711}
	702 Move rcx, [rbx+320]
	703 Compare rcx, 0
	704 JumpIfEqual {1033}
	705 Move rdx, "armed"
	706 Move r9, 0
	707 Move r8, 0
	708 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	709 Move [rbx+136], 16
	710 Goto {970}
	711 Move [rbx+160], 1500
	712 Goto {970}
	713 Move rcx, typeof(Reloaded.Gameplay.Common)
	714 Move rdi, [rbx+320]
	715 Compare [rcx+228], r15
	716 JumpIfNotEqual {718}
	717 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	718 Move xmm1, [0x183C33C60]
	719 Move r8, 0
	720 Move xmm0, [0x183C33DC0]
	721 Call Common.RandRangeFloat, xmm0, xmm1, r8
	722 Compare rdi, 0
	723 JumpIfEqual {1033}
	724 Move r9, 0
	725 Move r8, 0
	726 Move xmm1, xmm0
	727 Move rcx, rdi
	728 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	729 Move [rbx+160], 200
	730 Goto {970}
	731 Move rdx, 0
	732 Move rcx, rbx
	733 Call Plant.IsInPlay, rcx, rdx
	734 Compare rax, 0
	735 JumpIfEqual {970}
	736 Move rcx, [rbx+320]
	737 Move [rbx+156], 100
	738 Compare rcx, 0
	739 JumpIfEqual {1033}
	740 Move rdx, "explode"
	741 Move r9, 3
	742 Move r8, 0
	743 Move stack:0x20, r15
	744 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8, r9
	745 Move r8, [rbx+16]
	746 Compare r8, 0
	747 JumpIfEqual {1033}
	748 Move r8, [r8+88]
	749 Compare r8, 0
	750 JumpIfEqual {1033}
	751 Move rdx, typeof(Reloaded.Services.IAudioService)
	752 Move rcx, 6
	753 Move r9, 57
	754 Call 0x180002040, rcx, rdx, r8, r9
	755 Goto {970}
	756 Move [rbx+140], 400
	757 Goto {970}
	758 Move [rbx+140], 0x1F40
	759 Move [rbx+44], 80
	760 Goto {782}
	761 Move [rbx+140], 4000
	762 Move rcx, typeof(Reloaded.Gameplay.Common)
	763 Compare [rcx+228], r15
	764 JumpIfNotEqual {766}
	765 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	766 Move rdx, 0
	767 Move rcx, 1000
	768 Call Common.Rand, rcx, rdx
	769 Move rcx, [rbx+320]
	770 Add rax, rax, 1000
	771 Move [rbx+252], rax
	772 Compare rcx, 0
	773 JumpIfEqual {1033}
	774 Move xmm0, [0x183C33F80]
	775 LoadAddress rdx, stack:0x40
	776 Move r9, 0
	777 Move stack:0x40, xmm0
	778 Move r8, 0
	779 Call ReloadedController.SetColorOverride, rcx, rdx, r8
	780 Goto {970}
	781 Move [rbx+140], 4000
	782 Move rcx, typeof(Reloaded.Gameplay.Common)
	783 Compare [rcx+228], r15
	784 JumpIfNotEqual {786}
	785 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	786 Move rdx, 0
	787 Move rcx, 1000
	788 Call Common.Rand, rcx, rdx
	789 Add rax, rax, 1000
	790 Move [rbx+252], rax
	791 Goto {970}
	792 Move rcx, typeof(Reloaded.Gameplay.Common)
	793 Compare [rcx+228], r15
	794 JumpIfNotEqual {796}
	795 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	796 Move xmm1, [0x183C33DBC]
	797 Move r8, 0
	798 Move xmm0, xmm6
	799 Call Common.RandRangeFloat, xmm0, xmm1, r8
	800 Move rcx, [rbx+320]
	801 Move xmm6, xmm0
	802 Compare rcx, 0
	803 JumpIfEqual {1033}
	804 Move r9, 0
	805 Move r8, 0
	806 Move xmm1, xmm0
	807 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	808 Move rcx, [rbx+320]
	809 Compare rcx, 0
	810 JumpIfEqual {1033}
	811 Move rdx, "head_idle1"
	812 Move xmm3, xmm6
	813 Move r8, 2
	814 Move stack:0x20, r15
	815 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	816 Move rcx, [rbx+320]
	817 Compare rcx, 0
	818 JumpIfEqual {1033}
	819 Move rdx, "head_idle2"
	820 Move xmm3, xmm6
	821 Move r8, 3
	822 Move stack:0x20, r15
	823 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	824 Move rcx, [rbx+320]
	825 Compare rcx, 0
	826 JumpIfEqual {1033}
	827 Move rdx, "head_idle3"
	828 Move xmm3, xmm6
	829 Move r8, 4
	830 Goto {968}
	831 Move rcx, typeof(Reloaded.Gameplay.Common)
	832 Compare [rcx+228], r15
	833 JumpIfNotEqual {835}
	834 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	835 Move xmm1, [0x183C33DBC]
	836 Move r8, 0
	837 Move xmm0, xmm6
	838 Call Common.RandRangeFloat, xmm0, xmm1, r8
	839 Move rcx, [rbx+320]
	840 Move xmm6, xmm0
	841 Compare rcx, 0
	842 JumpIfEqual {1033}
	843 Move r9, 0
	844 Move r8, 0
	845 Move xmm1, xmm0
	846 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	847 Move rcx, [rbx+320]
	848 Compare rcx, 0
	849 JumpIfEqual {1033}
	850 Move rdx, "head_idle"
	851 Move xmm3, xmm6
	852 Move r8, 2
	853 Move stack:0x20, r15
	854 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	855 Move rcx, [rbx+320]
	856 Compare rcx, 0
	857 JumpIfEqual {1033}
	858 Move rdx, "splitpea_idle"
	859 Move xmm3, xmm6
	860 Move stack:0x28, r15
	861 Move r8, 3
	862 Move stack:0x20, r15
	863 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	864 Goto {970}
	865 Move rcx, typeof(UnityEngine.Object)
	866 Move rdi, [rbx+320]
	867 Compare [rcx+228], r15
	868 JumpIfNotEqual {870}
	869 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	870 Move r8, 0
	871 Move rdx, 0
	872 Move rcx, rdi
	873 Call Object.op_Inequality, rcx, rdx, r8
	874 Compare rax, 0
	875 JumpIfEqual {970}
	876 Move rcx, [rbx+320]
	877 Compare rcx, 0
	878 JumpIfEqual {1033}
	879 Move r8, 0
	880 Move rdx, 0
	881 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	882 Move rcx, [rbx+320]
	883 Compare rcx, 0
	884 JumpIfEqual {1033}
	885 Move rdx, "head_idle"
	886 Move xmm3, xmm0
	887 Move r8, 2
	888 Goto {968}
	889 Move [rbx+156], 50
	890 Compare [rbx+24], r15
	891 JumpIfEqual {962}
	892 Compare [rbx+311], r15
	893 JumpIfEqual {962}
	894 Move rcx, [rbx+16]
	895 Compare rcx, 0
	896 JumpIfEqual {1033}
	897 Move rdx, 0
	898 Call GameplayActivity.get_GameMode, rcx, rdx
	899 Compare rax, 43
	900 JumpIfEqual {962}
	901 Move rcx, [rbx+16]
	902 Compare rcx, 0
	903 JumpIfEqual {1033}
	904 Move rdx, 0
	905 Call GameplayActivity.get_GameMode, rcx, rdx
	906 Compare rax, 50
	907 JumpIfEqual {962}
	908 Move rcx, [rbx+320]
	909 Compare rcx, 0
	910 JumpIfEqual {1033}
	911 Move xmm6, [0x183C33DBC]
	912 Move r8, 0
	913 Move rdx, "blow"
	914 Move xmm3, xmm6
	915 Move stack:0x28, r15
	916 Move stack:0x20, 3
	917 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	918 Move rdi, [rbx+16]
	919 Compare rdi, 0
	920 JumpIfEqual {1033}
	921 Move rdi, [rdi+520]
	922 Compare rdi, 0
	923 JumpIfEqual {1033}
	924 Move rcx, typeof(UnityEngine.Object)
	925 Move rdi, [rdi+176]
	926 Compare [rcx+228], r15
	927 JumpIfNotEqual {929}
	928 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	929 Move r8, 0
	930 Move rdx, 0
	931 Move rcx, rdi
	932 Call Object.op_Inequality, rcx, rdx, r8
	933 Compare rax, 0
	934 JumpIfEqual {970}
	935 Compare rdi, 0
	936 JumpIfEqual {1033}
	937 Move xmm0, [0x183C33D58]
	938 Move rdx, 0xFFFFFFFF
	939 Move xmm3, [0x183C33C40]
	940 Move r8, 2
	941 Move stack:0x30, r15
	942 Move rcx, rdi
	943 Move stack:0x28, r15
	944 Move stack:0x20, xmm0
	945 Call FogController.SetTarget, rcx, rdx, xmm2, xmm3, stack:0x0, stack:0x8
	946 Move rcx, [rbx+16]
	947 Compare rcx, 0
	948 JumpIfEqual {1033}
	949 Move rcx, [rcx+256]
	950 Compare rcx, 0
	951 JumpIfEqual {1033}
	952 Move rdx, 0
	953 Call Board.LeftFogColumn, rcx, rdx
	954 Move xmm3, xmm6
	955 Move stack:0x28, r15
	956 Move r8, 3
	957 Move stack:0x20, xmm7
	958 Move rdx, rax
	959 Move rcx, rdi
	960 Call FogController.ScheduleTarget, rcx, rdx, xmm2, xmm3, stack:0x0
	961 Goto {970}
	962 Move rcx, [rbx+320]
	963 Compare rcx, 0
	964 JumpIfEqual {1033}
	965 Move rdx, "idle"
	966 Move xmm3, xmm7
	967 Move r8, 0
	968 Move stack:0x20, r15
	969 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	970 Move rcx, typeof(UnityEngine.Object)
	971 Move rdi, [rbx+16]
	972 Compare [rcx+228], r15
	973 JumpIfNotEqual {975}
	974 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	975 Move r8, 0
	976 Move rdx, 0
	977 Move rcx, rdi
	978 Call Object.op_Inequality, rcx, rdx, r8
	979 Compare rax, 0
	980 JumpIfEqual {997}
	981 Move rcx, [rbx+16]
	982 Compare rcx, 0
	983 JumpIfEqual {1033}
	984 Move rdx, 0
	985 Call GameplayActivity.get_GameMode, rcx, rdx
	986 Compare rax, 39
	987 JumpIfNotEqual {997}
	988 Compare [rbx+112], 3
	989 JumpIfEqual {994}
	990 Compare [rbx+112], 1
	991 JumpIfEqual {994}
	992 Compare [rbx+112], 38
	993 JumpIfNotEqual {997}
	994 Move rax, [rbx+140]
	995 Add rax, rax, rax
	996 Move [rbx+140], rax
	997 Compare [rbx+112], 33
	998 Move rax, [rbx+140]
	999 Move [rbx+144], rax
	1000 JumpIfEqual {1019}
	1001 Compare [rbx+24], r15
	1002 JumpIfEqual {1019}
	1003 Compare [rbx+311], r15
	1004 JumpIfEqual {1019}
	1005 Move r8, [rbx+52]
	1006 Move r9, 0
	1007 Move rdx, [rbx+116]
	1008 Move rcx, [rbx+24]
	1009 Call Board.GetFlowerPotAt, rcx, rdx, r8
	1010 Compare rax, 0
	1011 JumpIfEqual {1019}
	1012 Move rcx, [rax+320]
	1013 Compare rcx, 0
	1014 JumpIfEqual {1033}
	1015 Move r9, 0
	1016 Move r8, 0
	1017 Move xmm1, 0
	1018 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	1019 Move xmm8, stack:0x50
	1020 Move xmm7, stack:0x60
	1021 Move xmm6, stack:0x70
	1022 Move r15, stack:0xA8
	1023 Move r14, stack:0xA0
	1024 Move rbx, stack:0xB0
	1025 ShiftStack 128
	1026 Move rdi, stack:0x0
	1027 ShiftStack 8
	1028 Move rsi, stack:0x0
	1029 ShiftStack 8
	1030 Move rbp, stack:0x0
	1031 ShiftStack 8
	1032 Return 
	1033 Call 0x1804FEE20, rcx, rdx, r8, r9
	1034 Interrupt 
	1035 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
